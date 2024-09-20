using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class vehicleTitle : MonoBehaviour
{
    //changes title based on selected vehicle in the Vehicle Select Menu

    public void feisar()
    {
        this.GetComponent<TMP_Text>().text = "feisar";
    }
    public void goteki()
    {
        this.GetComponent<TMP_Text>().text = "goteki45";
    }
    public void auricom()
    {
        this.GetComponent<TMP_Text>().text = "auricom ind";
    }
    public void pirhana()
    {
        this.GetComponent<TMP_Text>().text = "pirhana-a";
    }
}
