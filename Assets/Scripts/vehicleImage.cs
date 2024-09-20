using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vehicleImage : MonoBehaviour
{
    //button assignable functions that changes graphic of Track Flavor Text based on chosen track
    public Sprite Feisar;
    public Sprite Goteki;
    public Sprite Auricom;
    public Sprite Pirhana;

    public void feisar()
    {
        this.GetComponent<Image>().sprite = Feisar;
    }
    public void goteki()
    {
        this.GetComponent<Image>().sprite = Goteki;
    }
    public void auricom()
    {
        this.GetComponent<Image>().sprite = Auricom;
    }
    public void pirhana()
    {
        this.GetComponent<Image>().sprite = Pirhana;
    }
}
