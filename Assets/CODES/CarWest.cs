using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWest : MonoBehaviour
{
    public bool startmove;

    void Start()
    {
        transform.Rotate(0f, 0.0f, -90f, Space.Self);
    }

    void Update()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWWest || startmove)
        {
            gameObject.transform.position += new Vector3(2 * Time.deltaTime, 0f, 0f);
        }

        else if (!GameObject.Find("ControlGame").GetComponent<ControlGame>().HWWest || !startmove)
        {
            gameObject.transform.position = gameObject.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TriggerWest")
        {
            startmove = true;
        }

        else if (collision.tag == "DTS")
        {
            Destroy(this.gameObject);
        }
    }
}
