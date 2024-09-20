using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;


//Begins a menu with a button already selected. Main menu already uses EventSystem to do this
public class menuLogic : MonoBehaviour
{
    public Controls playerControls;
    private InputAction back;

    GameObject lastButton;
    public GameObject SelectedButton;       //first button to be selected

    //back button
    private void Awake()
    {
        playerControls = new Controls();
    }

    private void OnEnable()
    {
        //back button
        back = playerControls.Menu.Cancel;
        back.Enable();
        back.performed += goBack;

        if (SelectedButton)
        {
            SelectedButton.SetActive(false);     //not sure why you need to reset the button before it is able to be shown as selected
            SelectedButton.SetActive(true);
            EventSystem.current.SetSelectedGameObject(SelectedButton);

        }

        //update currentMenu variable in mainLogic
        //this could have been easier
        if (this.gameObject.name == "League Select Menu") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.MainMenu, mainLogic.instance.LeagueSelectMenu); }
        else if (this.gameObject.name == "Time Trial") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.MainMenu, mainLogic.instance.TimeTrialMenu); }
        else if (this.gameObject.name == "Race Class") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.LeagueSelectMenu, mainLogic.instance.RaceClassMenu); }
        else if (this.gameObject.name == "Challenge Menu") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.LeagueSelectMenu, mainLogic.instance.ChallengeMenu); }
        else if (this.gameObject.name == "Tournament Menu") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.LeagueSelectMenu, mainLogic.instance.TournamentMenu); }
        else if (this.gameObject.name == "Track Menu")
        {
            if (mainLogic.instance.mode == mainLogic.Mode.SingleRace) { mainLogic.instance.updateCurrentMenu(mainLogic.instance.RaceClassMenu, mainLogic.instance.TrackMenu); }
            else if (mainLogic.instance.mode == mainLogic.Mode.TimeTrial) { mainLogic.instance.updateCurrentMenu(mainLogic.instance.NewTimeTrial, mainLogic.instance.TrackMenu); }
            else if (mainLogic.instance.mode == mainLogic.Mode.Tournament) { mainLogic.instance.updateCurrentMenu(mainLogic.instance.TournamentMenu, mainLogic.instance.TrackMenu); }
        }
        else if (this.gameObject.name == "Vehicle Select Menu") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.TrackMenu, mainLogic.instance.VehicleSelectMenu); }
        else if (this.gameObject.name == "Options Menu") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.MainMenu, mainLogic.instance.OptionsMenu); }
        else if (this.gameObject.name == "New Time Trial") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.TimeTrialMenu, mainLogic.instance.NewTimeTrial); }
        else if (this.gameObject.name == "Load Time Trial") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.TimeTrialMenu, mainLogic.instance.LoadTimeTrial); }
        //options menu
        else if (this.gameObject.name == "Game Setup") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.GameSetup); }
        else if (this.gameObject.name == "Controller Setup") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.ControllerSetup); }
        else if (this.gameObject.name == "Audio Setup") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.AudioSetup); }
        else if (this.gameObject.name == "Video Setup") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.VideoSetup); }
        else if (this.gameObject.name == "Records") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.Records); }
        else if (this.gameObject.name == "Link Up") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.EstablishLink); }
        else if (this.gameObject.name == "Load Save") { mainLogic.instance.updateCurrentMenu(mainLogic.instance.OptionsMenu, mainLogic.instance.LoadSave); }
    }
    private void OnDisable()
    {
        back.Disable();
    }

    //prevents button focus loss when clicking outside of the menu
    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(lastButton);
        }
        else
        {
            lastButton = EventSystem.current.currentSelectedGameObject;
        }
    }

    //back button
    public void goBack(InputAction.CallbackContext context)
    {
        if (this.gameObject.name != "Main Menu")
        {
            mainLogic.instance.prevMenu.SetActive(true);
            this.gameObject.SetActive(false);

            GameObject menuSounds = GameObject.Find("Menu Sounds");
            menuSounds.GetComponent<MenuSounds>().playSoundSelect();
        }
    }

    public void goBack()        //overload so exit buttons can use it
    {
        if (this.gameObject.name != "Main Menu")
        {
            mainLogic.instance.prevMenu.SetActive(true);
            this.gameObject.SetActive(false);

            GameObject menuSounds = GameObject.Find("Menu Sounds");
            menuSounds.GetComponent<MenuSounds>().playSoundSelect();
        }
    }
}
