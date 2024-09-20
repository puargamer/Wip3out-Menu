using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class trackTitle : MonoBehaviour
{
    //changes title based on selected track in the Track Menu
    public void portoKora()
    {
        this.GetComponent<TMP_Text>().text = "porto kora";
    }
    public void megaMall()
    {
        this.GetComponent<TMP_Text>().text = "mega mall";
    }
    public void sampaRun()
    {
        this.GetComponent<TMP_Text>().text = "sampa run";
    }
    public void stanzaInter()
    {
        this.GetComponent<TMP_Text>().text = "stanza inter";
    }
}
