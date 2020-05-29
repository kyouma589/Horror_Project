using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TableDialogue : MonoBehaviour
{

    public float distanceToObject;
    public TextMeshProUGUI table;
    public GameObject destinationObject;
    public bool tableRange;

    // Start is called before the first frame update
    void Start()
    {
        tableRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToObject = Vector3.Distance(this.transform.position, destinationObject.transform.position);

        if (distanceToObject <= 2) //If the player is close to the object in question, allow them to interact
        {
            Debug.Log("Close to table");
            tableRange = true;
            tableDialogue();
        }

        if (distanceToObject >= 3)
        {
            Debug.Log("Too far from table");
            tableRange = false;
            tableReset();
        }

    }

    //A function that will activate when the player left clicks on the object
    public void tableDialogue()
    {
        if (Input.GetMouseButtonDown(0))
        {
            table.text = "This is an old table. I found it a garage sale for cheap.";
        }
    }

    public void tableReset()
    {

        table.text = "";

    }
}
