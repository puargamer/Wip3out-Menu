using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


//contains all button functions
public class ButtonFunctions : MonoBehaviour
{
    //optional vars for image-changing buttons
    public Sprite selectedImage;
    public Sprite deselectedImage;

    public menuLogic Menu;

    //changes button color when selected
    public void changeColorSelect()
    {
        Color SelectedColor;
        UnityEngine.ColorUtility.TryParseHtmlString("#D6D6CE", out SelectedColor);
        this.GetComponent<TMP_Text>().color = SelectedColor;
    }
    public void changeColorDeselect()
    {
        this.GetComponent<TMP_Text>().color = Color.black;
    }

    //changes button image when selected
    public void changeImageSelect()
    {
        this.GetComponent<Image>().sprite = selectedImage;
    }

    public void changeImageDeselect()
    {
        this.GetComponent<Image>().sprite = deselectedImage;
    }

    //wrapper functions for changeImageSelect for Track Select buttons
    public void changeImageSelectTrack()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(308, 94);
        changeImageSelect();
    }
    public void changeImageDeselectTrack()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(251, 94);
        changeImageDeselect();
    }

    //wrapper functions for changeImageSelect for Vehicle Select buttons
    public void changeImageSelectVehicle()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(308, this.GetComponent<RectTransform>().sizeDelta.y);
        changeImageSelect();
    }
    public void changeImageDeselectVehicle()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2(251, this.GetComponent<RectTransform>().sizeDelta.y);
        changeImageDeselect();
    }

    //main menu options
    public void chooseSingleRace()
    {
        updateButtonSelect();
        mainLogic.instance.mode = mainLogic.Mode.SingleRace;
        goLeagueSelectMenu();
    }
    public void chooseChallenge()
    {
        updateButtonSelect();
        mainLogic.instance.mode = mainLogic.Mode.Challenge;
        goLeagueSelectMenu();
    }
    public void chooseTournament()
    {
        updateButtonSelect();
        mainLogic.instance.mode = mainLogic.Mode.Tournament;
        goLeagueSelectMenu();
    }
    public void chooseTimeTrial()
    {
        updateButtonSelect();
        mainLogic.instance.mode = mainLogic.Mode.TimeTrial;
        goTimeTrialMenu();
    }
    public void chooseOptions()
    {
        updateButtonSelect();
        mainLogic.instance.mode = mainLogic.Mode.Options;
        goOptionsMenu();
    }


    //league select options
    public void chooseWip3outLeague()
    {
        updateButtonSelect();
        mainLogic.instance.league = mainLogic.League.Wip3out;
    }
    public void chooseClassicLeague()
    {
        updateButtonSelect();
        mainLogic.instance.league = mainLogic.League.Classic;
    }

    //button used in League Select Menu. Goes to different menus
    public void leagueSelectButton()
    {
        if (mainLogic.instance.mode == mainLogic.Mode.SingleRace)
        {
            goRaceClassMenu();
        } else if (mainLogic.instance.mode == mainLogic.Mode.Challenge)
        {
            Debug.Log("this should work");
            goChallengeMenu();
        } else if (mainLogic.instance.mode == mainLogic.Mode.Tournament)
        {
            goTournamentMenu();
        }
    }

    //race class options
    public void chooseVector()
    {
        mainLogic.instance.raceClass = mainLogic.RaceClass.Vector;
    }
    public void chooseVenom()
    {
        mainLogic.instance.raceClass = mainLogic.RaceClass.Venom;
    }
    public void chooseRapier()
    {
        mainLogic.instance.raceClass = mainLogic.RaceClass.Rapier;
    }

    //track options
    public void choosePortoKora()
    {
        mainLogic.instance.track = mainLogic.Track.PortoKora;
    }
    public void chooseMegaMall()
    {
        mainLogic.instance.track = mainLogic.Track.MegaMall;
    }
    public void chooseSampaRun()
    {
        mainLogic.instance.track = mainLogic.Track.SampaRun;
    }
    public void chooseStanzaInter()
    {
        mainLogic.instance.track = mainLogic.Track.StanzaInter;
    }

    //vehicle options
    public void chooseFeisar()
    {
        mainLogic.instance.vehicle = mainLogic.Vehicle.Feisar;
    }
    public void chooseGoteki()
    {
        mainLogic.instance.vehicle = mainLogic.Vehicle.Goteki;
    }
    public void chooseAuricom()
    {
        mainLogic.instance.vehicle = mainLogic.Vehicle.Auricom;
    }
    public void choosePirhana()
    {
        mainLogic.instance.vehicle = mainLogic.Vehicle.Pirhana;
    }

    //low level menu navigation
    public void goLeagueSelectMenu()
    {
        mainLogic.instance.MainMenu.SetActive(false);
        mainLogic.instance.LeagueSelectMenu.SetActive(true);
    }
    public void goTimeTrialMenu()
    {
        mainLogic.instance.MainMenu.SetActive(false);
        mainLogic.instance.TimeTrialMenu.SetActive(true);
    }
    public void goRaceClassMenu()       //single race
    {
        mainLogic.instance.LeagueSelectMenu.SetActive(false);
        mainLogic.instance.RaceClassMenu.SetActive(true);
    }
    public void goChallengeMenu()       //challenge
    {
        mainLogic.instance.LeagueSelectMenu.SetActive(false);
        mainLogic.instance.ChallengeMenu.SetActive(true);
    }
    public void goTournamentMenu()      //tournament
    {
        mainLogic.instance.LeagueSelectMenu.SetActive(false);
        mainLogic.instance.TournamentMenu.SetActive(true);
    }

    public void goNewTimeTrial()
    {
        updateButtonSelect();
        mainLogic.instance.TimeTrialMenu.SetActive(false);
        mainLogic.instance.NewTimeTrial.SetActive(true);
    }
    public void goLoadTimeTrial()
    {
        updateButtonSelect();
        mainLogic.instance.TimeTrialMenu.SetActive(false);
        mainLogic.instance.LoadTimeTrial.SetActive(true);
    }


    public void goTrackMenu()
    {
        updateButtonSelect();

        mainLogic.instance.TournamentMenu.SetActive(false);
        mainLogic.instance.NewTimeTrial.SetActive(false);
        mainLogic.instance.RaceClassMenu.SetActive(false);
        mainLogic.instance.TrackMenu.SetActive(true);
    }
    public void goVehicleSelectMenu()
    {
        updateButtonSelect();
        mainLogic.instance.TrackMenu.SetActive(false);
        mainLogic.instance.VehicleSelectMenu.SetActive(true);
    }

    public void goChallengeSelect()
    {
        updateButtonSelect();
        mainLogic.instance.ChallengeMenu.SetActive(false);
        mainLogic.instance.ChallengeSelect.SetActive(true);
    }
    public void goChallengeStart()
    {
        updateButtonSelect();
        mainLogic.instance.ChallengeSelect.SetActive(false);
        mainLogic.instance.ChallengeStart.SetActive(true);
    }

    public void goOptionsMenu()
    {
        mainLogic.instance.MainMenu.SetActive(false);
        mainLogic.instance.OptionsMenu.SetActive(true);
    }

    //options button menus
    public void goOptionsGameSetup()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.GameSetup.SetActive(true);
    }
    public void goOptionsControllerSetup()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.ControllerSetup.SetActive(true);
    }
    public void goOptionsAudioSetup()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.AudioSetup.SetActive(true);
    }
    public void goOptionsVideoSetup()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.VideoSetup.SetActive(true);
    }
    public void goOptionsRecords()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.Records.SetActive(true);
    }
    public void goOptionsLinkUp()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.EstablishLink.SetActive(true);
    }
    public void goOptionsLoadSave()
    {
        updateButtonSelect();
        mainLogic.instance.OptionsMenu.SetActive(false);
        mainLogic.instance.LoadSave.SetActive(true);
    }

    public void updateButtonSelect()
    {
        Menu.SelectedButton = this.gameObject;
    }
}
