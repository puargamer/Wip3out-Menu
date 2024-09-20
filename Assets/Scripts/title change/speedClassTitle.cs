using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class speedClassTitle : MonoBehaviour
{
    //changes title based on selected speed in the Race Class Menu

    public void vector()
    {
        this.GetComponent<TMP_Text>().text = "vector";
    }
    public void venom()
    {
        this.GetComponent<TMP_Text>().text = "venom";
    }
    public void rapier()
    {
        this.GetComponent<TMP_Text>().text = "rapier";
    }

}
