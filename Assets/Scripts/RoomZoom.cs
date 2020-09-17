using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RoomZoom : MonoBehaviour
{
    public GameObject openRoom;
    public GameObject topHudHide;
    public GameObject botHudHide;
    public GameObject furniture;
    public GameObject background;
    public GameObject backgroundZoomOut;
    public GameObject UIClose;
    public GameObject lockedRoom;
    public GameObject lockedRoom2;
    public GameObject lockedRoom3;
    void Update()
    {

        if (Furniture.zoomActive == "y")
        {
            // Zoom in
            backgroundZoomOut.SetActive(true);
            background.SetActive(false);
            Camera.main.orthographicSize = 7f;
            GameObject.Find("Main Camera").transform.position = new Vector3(32, 15, -60);
        }

        //Zoom out
        //vector3 safearea = gameobject.find("openhouse").transform.position;

        //Rect zoneofzoomout = new Rect(0, 0, Screen.width / 4, Screen.height);   // how to setup needed rectangle on a main screen?
        //    if (Input.GetMouseButtonDown(0) && zoneofzoomout.Contains(Input.mousePosition))
        //    {
        //        background.SetActive(true);
        //        topHudHide.SetActive(true);
        //        botHudHide.SetActive(true);
        //        furniture.SetActive(false);
        //        Furniture.zoomActive = "n";
        //        Camera.main.orthographicSize = 22.22f;
        //        GameObject.Find("Main Camera").transform.position = new Vector3(51.2f, 23.24f, -10f);
        //    }
    }

    public void ZoomOut()
    {
        //UIClose.SetActiveRecursively(false);

        if (party.partyGoesOn == "y"){
        }else
        {
        lockedRoom.SetActive(true);
        lockedRoom2.SetActive(true);
        lockedRoom3.SetActive(true);
        backgroundZoomOut.SetActive(false);
        background.SetActive(true);
        topHudHide.SetActive(true);
        botHudHide.SetActive(true);
        furniture.SetActive(false);
        Furniture.zoomActive = "n";
        Camera.main.orthographicSize = 22.22f;
        GameObject.Find("Main Camera").transform.position = new Vector3(51.2f, 23.24f, -10f);
        GameObject[] uiForClose;
        uiForClose = GameObject.FindGameObjectsWithTag("FurniUI");
            foreach (GameObject i in uiForClose)
            {
                i.SetActive(false);
            }
        }
    }
}
