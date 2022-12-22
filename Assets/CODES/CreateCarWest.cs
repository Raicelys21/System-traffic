using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCarWest : MonoBehaviour
{
    int random;
    public GameObject[] CarW;

    void Start()
    {
        InvokeRepeating("CarWest", 0, 1f);
    }

    void CarWest()
    {
        if (GameObject.Find("ControlGame").GetComponent<ControlGame>().HWWest)

        {
            random = Random.Range(0, 10);
            Instantiate(CarW[random], transform.position, Quaternion.identity);
        }
    }
}
