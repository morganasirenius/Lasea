using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SeaController : MonoBehaviour
{
    [SerializeField] private float speed;
    private SeaInputControls seaInputControls;
    private Rigidbody2D rb;
    private Collider2D col;
    private PhotonView PV;

    Vector2 moveAmount;
    private void Awake()
    {
        seaInputControls = new SeaInputControls();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        PV = GetComponent<PhotonView>();
    }

    private void OnEnable()
    {
        seaInputControls.Enable();
    }

    private void OnDisable()
    {
        seaInputControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!PV.IsMine)
        {
            Destroy(rb);
        }
    }

    private void HorizontalMove()
    {
        //if (!PV.IsMine) return;
        float horizontalMovementInput = seaInputControls.Sea.HorizontalMove.ReadValue<float>();
        moveAmount.x = horizontalMovementInput * speed;
    }

    private void VerticalMove()
    {
        //if (!PV.IsMine) return;
        float verticalMovementInput = seaInputControls.Sea.VerticalMove.ReadValue<float>();
        moveAmount.y = verticalMovementInput * speed;
    }

    // Update is called once per frame
    void Update()
    {   
        if (!PV.IsMine) return;
        VerticalMove();
        HorizontalMove();
    }

    void FixedUpdate()
    {  
        if (!PV.IsMine) return;
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);
    }
}
