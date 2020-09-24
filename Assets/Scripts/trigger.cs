using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private int clickedTimes;
   IconsClick iconsClick;
    Animator petstagramAnimator;

    private void Awake()
    {
        clickedTimes = 0;
        petstagramAnimator = GameObject.Find("PetstagramButton").GetComponent<Animator>();
    }


    public void ClickCounter()
    {
        clickedTimes++;
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
        if( clickedTimes > 0)
        {
            //iconsClick.petstagIcon.SetBool("noPulse", true);
            petstagramAnimator.SetBool("noPulse", true);
        } 
    }

}
