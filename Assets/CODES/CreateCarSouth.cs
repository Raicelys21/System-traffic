using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCarSouth : MonoBehaviour
{
    int random;
    public GameObject[] CarS;

    void Start()
    {
        InvokeRepeating("CarSouth", 0, 1f);
    }

    void CarSouth()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWSouth)

        {
            random = Random.Range(0, 10);
            Instantiate(CarS[random], transform.position, Quaternion.identity);
        }
    }
}
