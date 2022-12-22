using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSpeed : MonoBehaviour
{

    public ControlTime slider;
    public Slider SLR;

    public void Slow()
    {
        slider.counttime = 1f;
        SLR.value = slider.counttime;
    }

    public void Intermediate()
    {
        slider.counttime = 3f;
        SLR.value = slider.counttime;
    }

    public void Fast()
    {
        slider.counttime =6f;
        SLR.value = slider.counttime;
    }
}
