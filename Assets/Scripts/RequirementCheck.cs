using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementCheck : MonoBehaviour
{

    [SerializeField] GameObject undoneRequirementMessage;
    [SerializeField] GameObject doneRequirementMessage;
    [SerializeField] GameObject previousWindow;

    public void checkIfFurnitureIsPlaced()
    {
        previousWindow.SetActive(false);
        if (checkFurnitureRequirementsToStartParty() == true)
        {
            doneRequirementMessage.SetActive(true);
        }
        else
        {
            undoneRequirementMessage.SetActive(true);
        }
    }

    private bool checkFurnitureRequirementsToStartParty()
    {
        int furnitureCheckCounter = 0;

        GameObject[] allObjects = (GameObject[])FindObjectsOfType(typeof(GameObject));
        for (int i = 0; i < allObjects.Length; i++)
        {
            if (allObjects[i].name.Contains("Carpet(Clone)") || allObjects[i].name.Contains("Bed(Clone)")) { 
            furnitureCheckCounter++;
                Debug.Log(furnitureCheckCounter.ToString());
            }
        }

        if (furnitureCheckCounter == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }




}
