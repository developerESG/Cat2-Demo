using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseWindow : MonoBehaviour
{

    public GameObject window;
    [SerializeField] GameObject newLVL;

    public void openWindow()
    {

        GameObject[] uiForClose;
        uiForClose = GameObject.FindGameObjectsWithTag("FurniUI");
        foreach (GameObject i in uiForClose)
        {
            i.SetActive(false);
        }
        window.SetActive(true);
    }

    public void closeWindow()
    {
        window.SetActive(false);
    }

    private void Update()
    {
        NewLevel();
    }

    public void NewLevel()
    {
        if(PartyStarted.partyDone == "y")
        {
            newLVL.SetActive(true);
        }
    }


}
