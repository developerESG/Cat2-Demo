using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconsClick : MonoBehaviour
{
    [SerializeField] private Animator petstagIcon,partyIcon,guestbook, furniture;

    // Start is called before the first frame update
    private void Awake()
    {
        petstagIcon.SetBool("noPulse", false);
    }

    void Start()
    {
       
        partyIcon.SetBool("noPulse", true);
        guestbook.SetBool("noPulse", true);
        furniture.SetBool("noPulse", true);
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            petstagIcon.SetBool("noPulse", true);
            partyIcon.SetBool("noPulse", true);
            guestbook.SetBool("noPulse", true);
            furniture.SetBool("noPulse", true);
        }

    }

}
