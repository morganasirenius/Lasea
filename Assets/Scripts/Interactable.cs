using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;
    private LandInputControls landInputControls;
    [SerializeField] private string playerTag;
    void Awake()
    {
        landInputControls = new LandInputControls();
    }

    private void OnEnable()
    {
        landInputControls.Enable();
    }

    private void OnDisable()
    {
        landInputControls.Disable();
    }
    void Start()
    {
        landInputControls.Land.Interact.performed += _ => Interact();
    }
    void Interact()
    {
        if(isInRange) interactAction.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(playerTag)) isInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(playerTag)) isInRange = false;
    }
}
