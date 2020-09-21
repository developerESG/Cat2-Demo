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
    


    private void Update()
    {
        if (PartyStarted.partyDone == "y" && popout.activeSelf)//!popout.activeInHierarchy)
        {
            StartCoroutine(GainFollowers());
            Debug.Log("Party was done. Gain followers!");
        }
    }
    IEnumerator GainFollowers()
    {
        while (followerCount < 6)
        {
            followersText.text = followerCount.ToString("0");
            yield return new WaitForSeconds(1f);
            followerCount++;
        }
    }
}
