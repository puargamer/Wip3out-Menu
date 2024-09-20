using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class medal : MonoBehaviour
{
    //changes color of medal
    public Sprite None;
    public Sprite Bronze;
    public Sprite Silver;
    public Sprite Gold;

    public void none()
    {
        this.GetComponent<Image>().sprite = None;
    }
    public void bronze()
    {
        this.GetComponent<Image>().sprite = Bronze;
    }
    public void silver()
    {
        this.GetComponent<Image>().sprite = Silver;
    }
    public void gold()
    {
        this.GetComponent<Image>().sprite = Gold;
    }
}
