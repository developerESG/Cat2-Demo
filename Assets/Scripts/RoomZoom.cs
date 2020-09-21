using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public GameObject lockedRoom4;
    private bool alreadyOfferedPartyStart;
    private bool alreadyOfferedPartyStartFinal;
    public GameObject passiveOfferToPartyStart;
    public GameObject passiveOfferYesBtn;
    public GameObject passiveOfferNoBtn;
    public GameObject passiveOfferOkBtn;


    public Transform currentView;


    public bool zoomActive;
    public Vector3[] target;
    public Camera cam;
    public float speed;
    private bool check;

    void Start()
    {
        cam = Camera.main;
    }
   /* void LateUpdate()
    {
        if (Furniture.zoomActive == "y")
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(32, 15, -60);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 7, speed);
        }
        if (PartyStarted.partyGoesOn == "y")
        {
            ZoomOut();
        }
    } */
    void Update()
    {

        if (Furniture.zoomActive == "y")
        {

            // Zoom in
            openRoom.GetComponent<GraphicRaycaster> ().enabled = false;
            backgroundZoomOut.SetActive(true);
            background.SetActive(false);
            //Camera.main.orthographicSize = 7f;                                             //new Vector3(32f, 15f, -60f)
            //cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 3, speed);
            //GameObject.Find("Main Camera").transform.position = new Vector3(32, 15, -60);//Vector3.Lerp(transform.position, new Vector3(32f, 15f, -60f), Time.deltaTime * 5); // new Vector3(32, 15, -60); old
            zoomActive = true;
            check = true;

            if (FurnRequirementCounter.medFurPlaced == true &&
                FurnRequirementCounter.carpetPlaced == true &&
                alreadyOfferedPartyStart == false &&
                PartyStarted.partyGoesOn == "n")
            {
                passiveOfferToPartyStart.SetActive(true);
                alreadyOfferedPartyStart = true;
                furniture.SetActive(false);
            }

            if (FurnRequirementCounter.medFurPlaced == true &&
                FurnRequirementCounter.carpetPlaced == true &&
                FurnRequirementCounter.bigFurPlaced == true &&
                FurnRequirementCounter.clockPlaced == true &&
                FurnRequirementCounter.chairPlaced == true &&
                FurnRequirementCounter.wallpaperPlaced == true &&
                FurnRequirementCounter.smallFurPlaced == true &&
                alreadyOfferedPartyStartFinal == false &&
                PartyStarted.partyDone == "n")
            {
                passiveOfferToPartyStart.SetActive(true);
                alreadyOfferedPartyStartFinal = true;
                furniture.SetActive(false);
                passiveOfferYesBtn.SetActive(false);
                passiveOfferNoBtn.SetActive(false);
                passiveOfferOkBtn.SetActive(true);
}
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


    public void LateUpdate()
    {
        if (Furniture.zoomActive == "y")
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 7, speed);
            cam.transform.position = new Vector3(openRoom.transform.position.x, openRoom.transform.position.y, cam.transform.position.z);

        }
    }
    /*     void LateUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, new Vector3(32, 15, -60), Time.deltaTime * 3);
            if (Furniture.zoomActive == "y")
                GameObject.Find("Main Camera").transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * 1);
    }
    */
    public void ZoomOut()
    {
        //UIClose.SetActiveRecursively(false);
        openRoom.GetComponent<GraphicRaycaster>().enabled = true;
        if (PartyStarted.partyGoesOn == "y"){
        }else
        {
        lockedRoom.SetActive(true);
        lockedRoom2.SetActive(true);
        lockedRoom3.SetActive(true);
        lockedRoom4.SetActive(true);
        backgroundZoomOut.SetActive(false);
        background.SetActive(true);
        topHudHide.SetActive(true);
        botHudHide.SetActive(true);
        furniture.SetActive(false);
        Furniture.zoomActive = "n";
        Camera.main.orthographicSize = 22.22f;
        GameObject.Find("Main Camera").transform.position = new Vector3(46f, 21.24f, -10f);
        GameObject[] uiForClose;
        uiForClose = GameObject.FindGameObjectsWithTag("FurniUI");
            foreach (GameObject i in uiForClose)
            {
                i.SetActive(false);
            }

            zoomActive = false;
            check = false;
        }
    }
}
