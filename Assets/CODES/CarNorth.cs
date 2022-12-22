using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarNorth : MonoBehaviour
{
    public bool startmove; 

    void Start()
    {       
        transform.Rotate(0f, 0f, -180f, Space.Self);        
    }

    void Update() {


        if(GameObject.Find("ControlGame").GetComponent<ControlGame>().HWNorth || startmove)
        {
            gameObject.transform.position += new Vector3(0f, -2 * Time.deltaTime, 0f);
        }

        else if(!GameObject.Find("ControlGame").GetComponent<ControlGame>().HWNorth || !startmove)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TriggerNorth")
        {
            startmove = true;
        }
        else if (collision.tag == "DTS")
        {
            Destroy(this.gameObject);
        }
    }
}
