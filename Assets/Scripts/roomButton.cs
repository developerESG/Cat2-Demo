using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomButton : MonoBehaviour
{
    Furniture furniture;
    public void RoomButton()
    {
        if (PartyStarted.partyGoesOn == "n")
        {
            furniture.openFurniture();
        }
    }
}
