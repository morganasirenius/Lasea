using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LandController : MonoBehaviour
{
    [SerializeField] private float speed, jumpSpeed;
    [SerializeField] private LayerMask ground;
    private LandInputControls landInputControls;
    private Rigidbody2D rb;
    private Collider2D col;
    private PhotonView PV;
    private Vector2 moveAmount;
    private void Awake()
    {
        landInputControls = new LandInputControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        PV = GetComponent<PhotonView>();
    }

    private void OnEnable()
    {
        landInputControls.Enable();
    }

    private void OnDisable()
    {
        landInputControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        landInputControls.Land.Jump.performed += _ => Jump();
        if (!PV.IsMine)
        {
            Destroy(rb);
        }
    }

    private void HorizontalMove()
    {
        //if (!PV.IsMine) return;
        float movementInput = landInputControls.Land.Move.ReadValue<float>();
        moveAmount.x += movementInput * speed * Time.fixedDeltaTime;
    }

    private bool IsGrounded()
    {   
        return true;
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= col.bounds.extents.x;
        topLeftPoint.y += col.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += col.bounds.extents.x;
        bottomRightPoint.y -= col.bounds.extents.y;
        //return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, ground);
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PV.IsMine) return;
        moveAmount = transform.position;
        HorizontalMove();
        
    }

    void FixedUpdate()
    {
        if (!PV.IsMine) return;
        transform.position = moveAmount;
    }
}
