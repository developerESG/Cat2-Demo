using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnRequirementCounter : MonoBehaviour
{
    [SerializeField] GameObject chair;
    [SerializeField] GameObject clock;
    [SerializeField] GameObject medFurniture;
    [SerializeField] GameObject bigFurniture;
    [SerializeField] GameObject smallFurniture;
    [SerializeField] GameObject carpet;
    [SerializeField] GameObject wallpaper;
    public static string furnReqPassiveCheck = "n";
    public static bool carpetPlaced;
    public static bool medFurPlaced;
    public static bool chairPlaced;
    public static bool bigFurPlaced;
    public static bool smallFurPlaced;
    public static bool clockPlaced;
    public static bool wallpaperPlaced;

    private void Update()
    {
        chairCheck();
        clockCheck();
        medFurnitCheck();
        bigFurnitCheck();
        smallFurnitCheck();
        carpetCheck();
        wallpaperCheck();
    }
    public void allFurnitureCheck()
    {
        //chairCheck();
        //clockCheck();
        medFurnitCheck();
        //bigFurnitCheck();
        //smallFurnitCheck();
        carpetCheck();
        //wallpaperCheck();
    }

    private void chairCheck()
    {
        GameObject findObj = GameObject.Find("Chair(Clone)");
        if (findObj != null)
        {
            Text txt = chair.GetComponentInChildren<Text>();
            txt.text = "1/1";
            chairPlaced = true;
        }
    }

    private void clockCheck()
    {
        GameObject findObj = GameObject.Find("Clock(Clone)");
        if (findObj != null)
        {
            Text txt = clock.GetComponentInChildren<Text>();
            txt.text = "1/1";
            clockPlaced = true;
        }
    }

    private void medFurnitCheck()
    {
        GameObject findObj = GameObject.Find("Bed(Clone)");
        if (findObj != null)
        {
            Text txt = medFurniture.GetComponentInChildren<Text>();
            txt.text = "1/1";
            medFurPlaced = true;
            Debug.Log("medFurCounter works");
            medFurPlaced = true;
        }
    }

    private void bigFurnitCheck()
    {
        GameObject findObj = GameObject.Find("TvTable(Clone)");
        if (findObj != null)
        {
            Text txt = bigFurniture.GetComponentInChildren<Text>();
            txt.text = "1/1";
            bigFurPlaced = true;
        }
    }

    private void smallFurnitCheck()
    {
        GameObject findObj = GameObject.Find("NightTable(Clone)");
        if (findObj != null)
        {
            Text txt = smallFurniture.GetComponentInChildren<Text>();
            txt.text = "1/1";
            smallFurPlaced = true;
        }
    }

    private void carpetCheck()
    {
        GameObject findObj = GameObject.Find("Carpet(Clone)");
        if (findObj != null)
        {
            Text txt = carpet.GetComponentInChildren<Text>();
            txt.text = "1/1";
            carpetPlaced = true;
            Debug.Log("carpetCounter works");
        }
    }

    private void wallpaperCheck()
    {
        GameObject findObj = GameObject.Find("house2new(Clone)");
        if (findObj != null)
        {
            Text txt = wallpaper.GetComponentInChildren<Text>();
            txt.text = "1/1";
            wallpaperPlaced = true;
        }
    }
}
