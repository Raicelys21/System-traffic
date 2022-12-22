using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSouth : MonoBehaviour
{
    public bool startmove;

    void Start()
    {
        transform.Rotate(0f, 0.0f, 0f, Space.Self);
    }

    void Update()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWSouth || startmove)
        {
            gameObject.transform.position += new Vector3(0f, 2 * Time.deltaTime, 0f);
        }

        else if (!GameObject.Find("ControlGame").GetComponent<ControlGame>().HWSouth || !startmove)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TriggerSouth")
        {
            startmove = true;
        }
        else if (collision.tag == "DTS")
        {
            Destroy(this.gameObject);
        }
    }
}
