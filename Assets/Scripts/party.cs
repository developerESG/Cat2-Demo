using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class party : MonoBehaviour
{
    public float timeStart = 30;
    public Text textBox;
    public static string partyDone = "n";
    public static string pigSpawned = "n";
    public static string pugSpawned = "n";
    public static string birdSpawned = "n";
    public static string partyGoesOn = "n";
    [SerializeField] GameObject pigBell;
    [SerializeField] GameObject pugBell;
    [SerializeField] GameObject birdBell;
    [SerializeField] GameObject pig;
    [SerializeField] GameObject pug;
    [SerializeField] GameObject bird;
    [SerializeField] GameObject timer;
    [SerializeField] GameObject partyEndMsg;
    [SerializeField] GameObject forceToPetstagram;
    private bool pigActive;
    private bool pugActive;
    private bool birdActive;
    float pigCurrentX;
    float pigPreviousX;
    float pugCurrentX;
    float pugPreviousX;
    float birdCurrentX;
    float birdPreviousX;

    float birdCurrentY;
    float birdPreviousY;


    private Transform myTransform;

    void Start()
    {
        textBox.text = timeStart.ToString();
        pigCurrentX = pigPreviousX = -19.84f;
        pugCurrentX = pugPreviousX = -14.64f;
        birdCurrentX = birdPreviousX = -9.5f;

        birdCurrentY = birdPreviousY = -9.5f;
    }

    void Update()
    {
        Timer();
        PigMove();
        PugMove();
        BirdMove();
    }

    public void Timer()
    {
        partyGoesOn = "y";
        timeStart -= Time.deltaTime;
        if (timeStart < 27 && timeStart > 19 && pigActive == false)
        {
            pigBell.SetActive(true);
        }
        else
        {
            pigBell.SetActive(false);
        }

        if (timeStart < 18 && timeStart > 10 && pugActive == false)
        {
            pugBell.SetActive(true);
        }
        else
        {
            pugBell.SetActive(false);
        }

        if (timeStart < 9 && timeStart > 1 && birdActive == false)
        {
            birdBell.SetActive(true);
        }
        else
        {
            birdBell.SetActive(false);
        }

        if (timeStart == 0 || timeStart < 0)
        {
            partyGoesOn = "n";
            pig.SetActive(false);
            pug.SetActive(false);
            bird.SetActive(false);
            timer.SetActive(false);
            partyEndMsg.SetActive(true);
        }
        textBox.text = Mathf.Round(timeStart).ToString();
        partyDone = "y";
    }


    public void PigSpawn()
    {
        pigSpawned = "y";
        pigActive = true;
        pig.SetActive(true);
    }
    public void PugSpawn()
    {
        pugSpawned = "y";
        pugActive = true;
        pug.SetActive(true);
    }
    public void BirdSpawn()
    {
        birdSpawned = "y";
        birdActive = true;
        bird.SetActive(true);
    }

    public void PigMove()
    {
        pig.transform.localPosition = new Vector3(-15.84f + Mathf.PingPong(Time.time, 5), -8.9f, 4);
        pigCurrentX = pig.transform.localPosition.x;

        if (pigPreviousX < pigCurrentX)
            pig.transform.localScale = new Vector3(0.25f,0.25f,0.25f);
        else
            pig.transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);

        pigPreviousX = pigCurrentX;
    }

    public void PugMove()
    {
        pug.transform.localPosition = new Vector3(-18f - Mathf.PingPong(Time.time, 2), -6.76f - Mathf.PingPong(Time.time, 2), 4);
        pugCurrentX = pug.transform.localPosition.x;

        if (pugPreviousX < pugCurrentX)
            pug.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        else
            pug.transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);

        pugPreviousX = pugCurrentX;
    }

    public void BirdMove()
    {
        bird.transform.localPosition = new Vector3(-6f + Mathf.PingPong(Time.time, 4), -8.8f , 4);
        //bird.transform.localPosition = new Vector3(-9.5f + Mathf.PingPong(Time.time, 4), -8.8f, 4);
        birdCurrentX = bird.transform.localPosition.x;
        birdCurrentY = bird.transform.localPosition.y;

        if (birdPreviousX < birdCurrentX)
            bird.transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
        else
            bird.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);

        birdPreviousX = birdCurrentX;

        birdPreviousY = birdCurrentY;
    }

    public void CloseRewardMsgAfterParty()
    {
        partyEndMsg.SetActive(false);
        forceToPetstagram.SetActive(true);
        Furniture.partyDone = "y";
    }
}
