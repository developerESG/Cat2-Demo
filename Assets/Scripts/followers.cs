using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class followers : MonoBehaviour
{
    [SerializeField] public Text followersText;
    private float followerCount;
    [SerializeField] private GameObject popout;
    public GameObject afterPartyStatistics;
    public GameObject closeButton1;
    private Button closeButton2;


    private void Start()
    {
        //StartCoroutine(Verify());
        closeButton2 = closeButton1.GetComponent<Button>();
    }

    public void startFollowerCount()
    {
        StartCoroutine(Verify());
        afterPartyStatistics.SetActive(true);
    }

    private IEnumerator Verify()
    {
        print(PartyStarted.partyDone);
        yield return new WaitForEndOfFrame();
        if (PartyStarted.partyDone == "y" /*&& popout.activeSelf*/)//!popout.activeInHierarchy)
        {
            StartCoroutine(GainFollowers());
            Debug.Log("Party was done. Gain followers!");
        }
    }

/*
    private void OnEnable()
    {
        if (PartyStarted.partyDone == "y")// && popout.activeSelf* !popout.activeInHierarchy) 
        {
            StartCoroutine(GainFollowers());
            Debug.Log("Party was done. Gain followers!");
        }
    } 
    */
    IEnumerator GainFollowers()
    {
        // for(int i = 0; i < 6; i++)
        for (int i = 0; i < 6; i++)
        {
            //followersText.text = followerCount.ToString("0");

            closeButton2.GetComponent<Button>().enabled = false;
            //closeButton2.enabled;
            yield return new WaitForSeconds(0.5f);
            followersText.text = i.ToString("0");
            //followerCount++;
            if (i == 5)
            closeButton2.GetComponent<Button>().enabled = true;

        }

    }
}
