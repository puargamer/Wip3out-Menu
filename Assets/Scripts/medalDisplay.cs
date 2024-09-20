using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class medalDisplay : MonoBehaviour
{
    //save data
    public Dictionary<string, string> saveDataVector = new Dictionary<string, string>
    {
        { "Porto Kora: Feisar", "gold" },
        { "Mega Mall: Feisar", "silver" },
        { "Sampa Run: Feisar", "bronze" }
    };

    public Dictionary<string, string> saveDataVenom = new Dictionary<string, string>
    {
        { "Porto Kora: Feisar", "gold" },
        { "Mega Mall: Feisar", "gold" },
        { "Sampa Run: Feisar", "gold" }
    };

    public Dictionary<string, string> saveDataRapier = new Dictionary<string, string>
    {
        { "Porto Kora: Feisar", "bronze" },
        { "Mega Mall: Feisar", "silver" },
        { "Sampa Run: Feisar", "gold" }
    };

    public List<GameObject> medalList;  //list of display medals

    private void OnEnable()
    {

        renderMedalDisplay();
    }

    //assigns medal sprites for each medal asset
    public void renderMedalDisplay()
    {
        Dictionary<string, string> saveData = new Dictionary<string, string>();
        GameObject medal;

        
        if (mainLogic.instance.raceClass == mainLogic.RaceClass.Vector)
        {
            saveData = new Dictionary<string, string>(saveDataVector);
        }
        else if (mainLogic.instance.raceClass == mainLogic.RaceClass.Venom)
        {
            saveData = new Dictionary<string, string>(saveDataVenom);
        }
        else if (mainLogic.instance.raceClass == mainLogic.RaceClass.Rapier)
        {
            saveData = new Dictionary<string, string>(saveDataRapier);
        }
        

        foreach (KeyValuePair<string, string> entry in saveData)    //goes through all save data
        {
            for (int i = 0; i < medalList.Count; i++)    //finds display medal in list
            {
                medal = medalList[i];
                if (entry.Key == medal.name)
                {
                    assignMedal(medal, entry.Value);
                    break;
                }
            }
        }
    }

    //changes medal sprite given a display medal and save data
    private void assignMedal(GameObject medal, string data)
    {
        if (data == "gold")
        {
            medal.GetComponent<medal>().gold();
        }
        else if (data == "silver")
        {
            medal.GetComponent<medal>().silver();
        }
        else if (data == "bronze")
        {
            medal.GetComponent<medal>().bronze();
        }
        else if (data == "none")
        {
            medal.GetComponent<medal>().none();
        }
    }
}
