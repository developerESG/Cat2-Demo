using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public bool zoomActive;
    public Vector3[] target;
    public Camera cam;
    public float speed;

    public float transitionSpeed;
    public Transform currentView;

    void Start()
    {
        cam = Camera.main;
    }

    public void LateUpdate()
    {
        if (zoomActive)
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(32, 15, -60);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 7, speed);
        }
    /*    else
        {
            Camera.main.orthographicSize = 22.22f;
            GameObject.Find("Main Camera").transform.position = new Vector3(51.2f, 21.24f, -10f);
        } */
    }


    /*
    public float transitionSpeed;
    public Transform currentView;
    private bool trig;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            trig = true;
        }
    }

    private void LateUpdate()
    {
        if (trig == true)
        {
            Camera.main.orthographicSize = 7f;
            transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
        }
    }

    */
}
