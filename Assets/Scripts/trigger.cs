using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private int clickedTimesGB, clickedTimesParty, clickedTimesPetstag;
   IconsClick iconsClick;
    Animator petstagramAnimator, partyAnimator, GBAnimator;

    private void Awake()
    {
        clickedTimesGB = 0;
        clickedTimesParty = 0;
        clickedTimesPetstag = 0;
        petstagramAnimator = GameObject.Find("PetstagramButton").GetComponent<Animator>();
        partyAnimator = GameObject.Find("PartyIcon").GetComponent<Animator>();
        GBAnimator = GameObject.Find("GuestbookButton").GetComponent<Animator>();
    }


    public void GBClickCounter()
    {
        clickedTimesGB++;
    }
    
    public void PartyClickCounter()
    {
        clickedTimesParty++;
    }
    
    public void PetstagClickCounter()
    {
        clickedTimesPetstag++;
    }

    public void Activator()
    {
        GetComponent<Animator>().SetBool("noPulse", false);

    }

    public void DeActivator()
    {
        GetComponent<Animator>().SetBool("noPulse", true);

    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }

    public void PetstagramCheck()
    {        
        if ( clickedTimesPetstag > 0)
        {
            //iconsClick.petstagIcon.SetBool("noPulse", true);

            petstagramAnimator.SetBool("noPulse", true);
        } 
    }

    public void PartygetsChecked()
    {
        if (clickedTimesParty > 0)
        {
            partyAnimator.SetBool("noPulse", true);
        }

        if (!partyAnimator.GetBool("noPulse"))
        {
            partyAnimator.SetBool("noPulse", true);
        }
        else
        {
            partyAnimator.SetBool("noPulse", false);
        }
    }

    public void GBCheck()
    {
        if (clickedTimesGB > 0)
        {
            GBAnimator.SetBool("noPulse", true);
        }
        if (!GBAnimator.GetBool("noPulse"))
        {
            GBAnimator.SetBool("noPulse", true);
        }
    }
}
