using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks; // For Tasks
using System; // For Time.Span

public class ControlGame : MonoBehaviour
{
    // Highway and cars direction
    public List<GameObject> TrafficLightsNorth;
    public List<GameObject> TrafficLightsSouth;
    public List<GameObject> TrafficLightsWest;
    public List<GameObject> TrafficLightsEast;

    // Traffic light
    public bool HWNorth;
    public bool HWEast;
    public bool HWSouth;
    public bool HWWest;

    // Speed sensor
    public float speednorth;
    public float speedwest; //velocity0
    public float speedeast;
    public float speedsouth;

    // Call other class for count the time
    public ControlTime ControlTime;

    void Start()
    {
        // Start all traffic light off and 
        TrafficLightOFF();
        StartCoroutine(TrafficLightStart());
        Time.timeScale = ControlTime.counttime;
    }


    private void Update()
    {
        Time.timeScale = ControlTime.counttime;
    }

    IEnumerator TrafficLightStart()
    {
        while (true)
        {
            //North
            TrafficLightNorthGREEN(); //Green light traffic
            yield return new WaitForSeconds(ControlTime.counttime);
            TrafficLightNorthYELLOW(); // Yellow light traffic
            yield return new WaitForSeconds(ControlTime.counttime);

            //South
            TrafficLightSouthGREEN(); //Green light traffic
            yield return new WaitForSeconds(ControlTime.counttime);
            TrafficLightSouthYELLOW(); // Yellow light traffic
            yield return new WaitForSeconds(ControlTime.counttime);

            //East
            TrafficLightEastGREEN();
            yield return new WaitForSeconds(ControlTime.counttime);
            TrafficLightEastYELLOW(); // Yellow light traffic
            yield return new WaitForSeconds(ControlTime.counttime);

            //West
            TrafficLightWestGREEN(); //Green light traffic
            yield return new WaitForSeconds(ControlTime.counttime);
            TrafficLightWestYELLOW(); // Yellow light traffic
            yield return new WaitForSeconds(ControlTime.counttime);
        }
    }

    /* The organization is:
        0. red
        1. yellow
        2. green 
    */

    //Traffic light north
    void TrafficLightNorthGREEN()
    {
        //North
        TrafficLightsNorth[0].SetActive(false);
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(true); // Green

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(true); // Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = true;
        HWEast = false;
        HWSouth = false;
        HWWest = false;
    }

    void TrafficLightNorthYELLOW()
    {
        //North
        TrafficLightsNorth[0].SetActive(false);
        TrafficLightsNorth[1].SetActive(true); // Yellow
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(true); // Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = true;
        HWEast = false;
        HWSouth = false;
        HWWest = false;
    }

    //Traffic light south
    void TrafficLightSouthGREEN()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); // Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(false);
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(true); // Green

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(true); // Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = false;
        HWEast = false;
        HWSouth = true;
        HWWest = false;
    }

    void TrafficLightSouthYELLOW()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); //Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(false);
        TrafficLightsSouth[1].SetActive(true); //Yellow
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(true); //Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = false;
        HWEast = false;
        HWSouth = true;
        HWWest = false;
    }

    //Traffic light east
    void TrafficLightEastGREEN()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); // Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(false);
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(true); // Green

        // West
        TrafficLightsWest[0].SetActive(true); // Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = false;
        HWEast = true;
        HWSouth = false;
        HWWest = false;
    }

    void TrafficLightEastYELLOW()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); //Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(false);
        TrafficLightsEast[1].SetActive(true); // Yellow
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(true); //Red
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);

        HWNorth = false;
        HWEast = true;
        HWSouth = false;
        HWWest = false;
    }

    //Traffic light west
    void TrafficLightWestGREEN()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); // Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(false);
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(true); // Green

        HWNorth = false;
        HWEast = false;
        HWSouth = false;
        HWWest = true;
    }

    void TrafficLightWestYELLOW()
    {
        //North
        TrafficLightsNorth[0].SetActive(true); // Red
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(true); // Red
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(true); // Red
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(false);
        TrafficLightsWest[1].SetActive(true); //Yellow
        TrafficLightsWest[2].SetActive(false);

        HWNorth = false;
        HWEast = false;
        HWSouth = false;
        HWWest = true;
    }

    //OFF traffic light
    void TrafficLightOFF()
    {   //Al light off 

        //North
        TrafficLightsNorth[0].SetActive(false);
        TrafficLightsNorth[1].SetActive(false);
        TrafficLightsNorth[2].SetActive(false);

        //South
        TrafficLightsSouth[0].SetActive(false);
        TrafficLightsSouth[1].SetActive(false);
        TrafficLightsSouth[2].SetActive(false);

        //East
        TrafficLightsEast[0].SetActive(false);
        TrafficLightsEast[1].SetActive(false);
        TrafficLightsEast[2].SetActive(false);

        // West
        TrafficLightsWest[0].SetActive(false);
        TrafficLightsWest[1].SetActive(false);
        TrafficLightsWest[2].SetActive(false);
    }
}