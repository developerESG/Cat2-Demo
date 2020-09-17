using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsClick : MonoBehaviour
{
    [SerializeField] private Animator petstagIcon,partyIcon;
    party party;
    // Start is called before the first frame update
    void Start()
    {
        partyIcon.SetBool("noPulse", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            petstagIcon.SetBool("noPulse", true);
            partyIcon.SetBool("noPulse", true);
        }

    }
}
