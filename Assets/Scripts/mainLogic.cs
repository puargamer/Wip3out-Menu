using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

//singleton storing global info
public class mainLogic : MonoBehaviour 
{
    //keeps track of what mode is selected using enums
    public enum Mode { SingleRace, TimeTrial, Challenge, Tournament, Options }
    public enum League { Wip3out, Classic }
    public enum RaceClass { Vector, Venom, Rapier }
    public enum Track { PortoKora, MegaMall, SampaRun, StanzaInter }
    public enum Vehicle { Feisar, Goteki, Auricom, Pirhana}

    public Mode mode;
    public League league;
    public RaceClass raceClass;
    public Track track;
    public Vehicle vehicle;
    //color of selected text
    [HideInInspector] public Color SelectedColor;

    //list of menus
    [Header("Main Menu")]
    public GameObject MainMenu;

    [Header("Level 1")]
    public GameObject LeagueSelectMenu;
    public GameObject TimeTrialMenu;
    public GameObject OptionsMenu;

    [Header("Level 2")]
    public GameObject RaceClassMenu;

    public GameObject NewTimeTrial;
    public GameObject LoadTimeTrial;

    public GameObject ChallengeMenu;
    public GameObject TournamentMenu;

    [Header("Level 3")]
    public GameObject TrackMenu;
    public GameObject ChallengeSelect;

    [Header("Level 4")]
    public GameObject VehicleSelectMenu;
    public GameObject ChallengeStart;

    [Header("Options")]
    public GameObject GameSetup;
    public GameObject ControllerSetup;
    public GameObject AudioSetup;
    public GameObject VideoSetup;
    public GameObject Records;
    public GameObject EstablishLink;
    public GameObject LoadSave;

    [Header("Navigation")]      //used for back button
    public GameObject currentMenu;
    public GameObject prevMenu;

    //singleton
    public static mainLogic instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        //Converts Hex Code to unity's RGB color format
        UnityEngine.ColorUtility.TryParseHtmlString("#D6D6CE", out SelectedColor);
    }

    //called by external funcs whenever a menu switch occurs 
    public void updateCurrentMenu(GameObject currentmenu, GameObject nextmenu)
    {
        prevMenu = currentmenu;
        currentMenu = nextmenu;
    }

}

