using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCarEast : MonoBehaviour
{
    int random;
    public GameObject[] CarE;

    void Start()
    {
       InvokeRepeating("CarEast", 0, 1f);
    }

    void CarEast()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWEast)

        {
            random = Random.Range(0, 10);
            Instantiate(CarE[random], transform.position, Quaternion.identity);
        }
    }
}
