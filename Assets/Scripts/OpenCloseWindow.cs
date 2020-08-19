using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseWindow : MonoBehaviour
{

    public GameObject window;

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



}
