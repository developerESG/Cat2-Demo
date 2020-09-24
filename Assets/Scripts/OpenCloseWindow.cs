using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseWindow : MonoBehaviour
{

    public GameObject window;
    [SerializeField] GameObject newLVL;
    //public GameObject robertPetstagram;
    public bool newLvLOnce;

    private void Start()
    {
        newLvLOnce = true;
    }

    public void openWindow()
    {

        GameObject[] uiForClose;
        uiForClose = GameObject.FindGameObjectsWithTag("FurniUI");
        foreach (GameObject i in uiForClose)
        {
            i.SetActive(false);
        }
        NewLevel();
        window.SetActive(true);
        /*
        if (PartyStarted.partyDone == "y" && newLvLOnce == true)
        {
            robertPetstagram.SetActive(false);
            newLVL.SetActive(true);
            newLvLOnce = false;

        }
        else
        {
            window.SetActive(true);
        }
        */
    }
/*
    public void openPestragramAfterNewLvl()
    {
        robertPetstagram.SetActive(true);
        window.SetActive(true);
    }
    */
    public void closeWindow()
    {
        window.SetActive(false);
    }

    private void Update()
    {
       // NewLevel();
    }

    public void NewLevel()
    {
        
        if(PartyStarted.partyDone == "y" && newLvLOnce == true)
        {
            newLVL.SetActive(true);
            newLvLOnce = false;
           
        }
    }
    

}
