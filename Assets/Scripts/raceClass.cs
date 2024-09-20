using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


//version of menuLogic for raceClass menu
public class raceClass : MonoBehaviour
{
    public GameObject Wip3outMenu;
    public GameObject ClassicMenu;

    private bool setMenu = false;

    public GameObject initialselectwip3out;
    public GameObject initialselectclassic;

    public menuLogic menu;

    private void OnEnable()
    {
        setMenu = false;

        //saving selected button while going back menus
        if (menu.SelectedButton != null)
        {
            if (mainLogic.instance.league == mainLogic.League.Wip3out)
            {
                initialselectwip3out = menu.SelectedButton;
            }
            if (mainLogic.instance.league == mainLogic.League.Classic)
            {
                initialselectclassic = menu.SelectedButton;
            }
        }


        if (setMenu == false)
        {
            displayMenu();
        }

    }

    private void displayMenu()
    {
        //Chooses 1 of 2 league menus to display and chooses initial button
        if (mainLogic.instance.league == mainLogic.League.Wip3out)
        {

            Wip3outMenu.SetActive(true);
            ClassicMenu.SetActive(false);

            initialselectwip3out.SetActive(false);     //not sure why you need to reset the button before it is able to be shown as selected
            initialselectwip3out.SetActive(true);
            EventSystem.current.SetSelectedGameObject(initialselectwip3out);
        }
        else if (mainLogic.instance.league == mainLogic.League.Classic)
        {

            Wip3outMenu.SetActive(false);
            ClassicMenu.SetActive(true);
            initialselectclassic.SetActive(false);     //not sure why you need to reset the button before it is able to be shown as selected
            initialselectclassic.SetActive(true);
            EventSystem.current.SetSelectedGameObject(initialselectclassic);
        }

        setMenu = true;
    }

}
