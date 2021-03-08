using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public InputControls inputControls;
    // Update is called once per frame
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Hana"))
        {
            isInRange = true;
            Debug.Log("In range");
        }
    }

    private void onTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Hana"))
        {
            isInRange = false;
            Debug.Log("Out of range");
        }
    }
}
