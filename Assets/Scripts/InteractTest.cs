using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractTest : MonoBehaviour
{

    public float distanceToObject;
    public TextMeshProUGUI test;
    public GameObject destinationObject;
    public bool textRange;

    // Start is called before the first frame update
    void Start()
    {   
        textRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToObject = Vector3.Distance(this.transform.position, destinationObject.transform.position);

        if (distanceToObject <= 2) //If the player is close to the object in question, allow them to interact
        {
            Debug.Log("Close enough");
            textRange = true;
            Dialogue();
        }        
    }

    //A function that will activate when the player left clicks on the object
    public void Dialogue()
    {
        if (Input.GetMouseButtonDown(0))
        {
            test.text = "WORKING.";
        }
    }
}
