using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePetstagramForceToOpen : MonoBehaviour
{
    [SerializeField] GameObject petstagramForceWindow;
    [SerializeField] GameObject petstagramPhotos;
    [SerializeField] GameObject guestBookInvatation;
    [SerializeField] Text numberOfFollowers;
    private bool partyChecker;

    public void ClosePetstagramForceWindow()
    {
        petstagramForceWindow.SetActive(false);

        if(Furniture.partyDone == "y"){
            petstagramPhotos.SetActive(true);
            numberOfFollowers.text = "5";
        }
    }

    public void CheckGuestBookAfterParty()
    {
        if (Furniture.partyDone == "y")
        {
            //guestBookInvatation.SetActive(true);
            Furniture.partyDone = "n";
        }
    }

}
