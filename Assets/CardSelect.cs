using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CardSelect : MonoBehaviour
{
    public Card CardSeleted;
    public Transform CardHold;

    public LayerMask Cardlayer;
    private Vector2 mousePos;

    Ray ray;
    RaycastHit hit;

    private void FixedUpdate()
    {
        mousePos = Input.mousePosition;
    }
    void Update()
    {
        CardHold.position = mousePos;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(mousePos);
            if(Physics.Raycast(ray,out hit,50,Cardlayer))
            {
                Debug.Log(hit.transform.gameObject.name);
                hit.transform.parent = CardHold;
            }
        }
    }
}
