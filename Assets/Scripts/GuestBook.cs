using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestBook : MonoBehaviour
{
    public GameObject guestbook;
    public GameObject previousWindow;
    [SerializeField] GameObject pigInfo;
    [SerializeField] GameObject pugInfo;
    [SerializeField] GameObject birdInfo;
    public GameObject restartPartyMsg;

    public void openGuestbook()
    {
        guestbook.SetActive(true);
        GuestPartyParticipationCheck();
    }

    public void StartParty()
    {
        if (party.partyDone == "y")
        {
            restartPartyMsg.SetActive(true);
            Debug.Log("Let's get party started");
        }
        else
        {
            openGuestbook();
        }
    }
    public void openAndCloseGuestbook()
    {
        guestbook.SetActive(true);
        previousWindow.SetActive(false);
    }

    public void closeGuestbook()
    {
        guestbook.SetActive(false);
    }

    public void ClosePreviousWindow()
    {
        previousWindow.SetActive(false);
    }

    private void GuestPartyParticipationCheck()
    {
  /*      if (PartyStarted.pigSpawned == "y")
        {
            pigInfo.SetActive(true);
        }
        if (PartyStarted.pugSpawned == "y")
        {
            pugInfo.SetActive(true);
        }
        if (PartyStarted.birdSpawned == "y")
        {
            birdInfo.SetActive(true);
        } 
  */

        if(party.partyDone == "y")
        {
            pigInfo.SetActive(true);
            pugInfo.SetActive(true);
            birdInfo.SetActive(true);

        }
    }
}
