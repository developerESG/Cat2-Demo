using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Furniture : MonoBehaviour
{
    public GameObject TopHudHide;
    public GameObject BotHudHide;
    public static string zoomActive = "n";
    public static string partyDone = "n";
    public static string accountSelected = "n";
    public GameObject furniture;
    public GameObject backGround;
    public GameObject rewardWindow;
    public GameObject timer;
    public GameObject shop;
    public GameObject partyRequirmentPassive;
    public GameObject afterPartyStatistics;
    public GameObject chairPlus;
    public GameObject clockPlus;
    public GameObject medFurPlus;
    public GameObject bigFurPlus;
    public GameObject carpet;
    public GameObject smallFurPlus;
    public GameObject wallpaper;


    public void selectAccount()
    {
        accountSelected = "y";
    }
    public void openFurniture()
    {
        closeLockedRooms();
        TopHudHide.SetActive(false);
        BotHudHide.SetActive(false);
        furniture.SetActive(true);
        zoomActive = "y";
        backGround.SetActive(false);
        if (PartyStarted.partyDone == "y")
        {
            GameObject[] uiToClose;
            uiToClose = GameObject.FindGameObjectsWithTag("FurniUI");
            foreach (GameObject i in uiToClose)
            {
                i.SetActive(false);
            }
        }
        //shop.SetActive(true);
    }

    public void openFurnitureAfterParty()
    {
        if (PartyStarted.partyDone == "y")
        {
            chairPlus.SetActive(false);
            clockPlus.SetActive(false);
            medFurPlus.SetActive(false);
            bigFurPlus.SetActive(false);
            carpet.SetActive(false);
            smallFurPlus.SetActive(false);
            wallpaper.SetActive(false);
        }
    }

    public void closeFurniture()
    {
        TopHudHide.SetActive(true);
        BotHudHide.SetActive(true);
        furniture.SetActive(false);
        zoomActive = "n";
        backGround.SetActive(true);
        //shop.SetActive(false);
    }

    public void startParty()
    {
        rewardWindow.SetActive(false);
        closeLockedRooms();
        TopHudHide.SetActive(false);
        BotHudHide.SetActive(false);
        zoomActive = "y";
        backGround.SetActive(false);
        timer.SetActive(true);
        partyRequirmentPassive.SetActive(false);
    }

    public void closeLockedRooms()
    {
        GameObject[] closedRoom;
        closedRoom = GameObject.FindGameObjectsWithTag("ClosedRoom");
        foreach (GameObject i in closedRoom)
        {
            i.SetActive(false);
        }
    }

    public void openLockedRooms()
    {
        GameObject[] closedRoom2;
        closedRoom2 = GameObject.FindGameObjectsWithTag("ClosedRoom");
        foreach (GameObject b in closedRoom2)
        {
            b.SetActive(true);
        }
    }

    public void RestartGame()
    {
        PlayerPrefs.DeleteAll();
        PartyStarted.partyDone = "n";
        SceneManager.LoadScene(0);
        FurnRequirementCounter.medFurPlaced = false;
        FurnRequirementCounter.carpetPlaced = false;
        FurnRequirementCounter.bigFurPlaced = false;
        FurnRequirementCounter.clockPlaced = false;
        FurnRequirementCounter.chairPlaced = false;
        FurnRequirementCounter.wallpaperPlaced = false;
        FurnRequirementCounter.smallFurPlaced = false;
        afterPartyStatistics.SetActive(false);

    }
}
