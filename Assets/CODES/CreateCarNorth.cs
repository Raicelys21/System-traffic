using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCarNorth : MonoBehaviour
{
    int random;
    public GameObject[] CarN;

    void Start()
    {
       InvokeRepeating("CarNorth", 0, 1f);
    }

    void CarNorth()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWNorth)

        {
            random = Random.Range(0, 10);
            Instantiate(CarN[random], transform.position, Quaternion.identity);
        }
    }
}
