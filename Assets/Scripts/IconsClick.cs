using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IconsClick : MonoBehaviour
{
    [SerializeField] private Animator petstagIcon,partyIcon,guestbook, furniture;
    [SerializeField] private GameObject newItems;
    [SerializeField] private Button guestBookIcon;
    trigger triggerScript;

    // Start is called before the first frame update
    private void Awake()
    {
        petstagIcon.SetBool("noPulse", false);
    }

    void Start()
    {
        guestBookIcon = GetComponent<Button>();
       
        partyIcon.SetBool("noPulse", true);
        guestbook.SetBool("noPulse", true);
        furniture.SetBool("noPulse", true);
    }

   
    // Update is called once per frame
    void Update()
    {

       if(PartyStarted.partyDone == "y")
        {
            partyIcon.SetBool("noPulse", true);
            petstagIcon.SetBool("noPulse", true);
            //guestbook.SetBool("noPulse", true);
            furniture.SetBool("noPulse", true);

            if (!newItems.activeInHierarchy)
            {
                //guestbook.SetBool("noPulse", false);
                
            }

        }
       
    }
    
}
