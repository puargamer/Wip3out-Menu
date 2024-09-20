using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trackFlavorText : MonoBehaviour
{
    //button assignable functions that changes graphic of Track Flavor Text based on chosen track
    public Sprite PortoKora;
    public Sprite MegaMall;
    public Sprite SampaRun;
    public Sprite StanzaInter;

    public void portoKora()
    {
        this.GetComponent<Image>().sprite = PortoKora;
    }
    public void megaMall()
    {
        this.GetComponent<Image>().sprite = MegaMall;
    }
    public void sampaRun()
    {
        this.GetComponent<Image>().sprite = SampaRun;
    }
    public void stanzaInter()
    {
        this.GetComponent<Image>().sprite = StanzaInter;
    }
}
