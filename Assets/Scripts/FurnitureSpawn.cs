﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FurnitureSpawn : MonoBehaviour
{
    [SerializeField] GameObject furniture;
    [SerializeField] float xPosition;
    [SerializeField] float yPosition;
    [SerializeField] float xScale;
    [SerializeField] float yScale;
    [SerializeField] GameObject currentFurPlusIcon;
    [SerializeField] GameObject zoomOutBG;
    private BoxCollider2D furCollider;
    private int currentObjectsCount = 1;

    /*
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0) //    Input.touchCount > 0
        {
            // Either touch down or Mouse click
            Debug.Log("Explosion");

            zoomOutBG.SetActive(false);
            currentFurPlusIcon.SetActive(false);
            if (EventSystem.current.IsPointerOverGameObject())
            {
                if (currentObjectsCount != 2)
                {
                    SpawnFurniture(GetFurniturePlaceClicked());
                }
            }
            zoomOutBG.SetActive(true);
        }

    }
    */

    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    private void OnMouseDown()
    {
        Debug.Log("Explosion");
        zoomOutBG.SetActive(false);
        currentFurPlusIcon.SetActive(false);
        //if (EventSystem.current.IsPointerOverGameObject())
        if(IsPointerOverUIObject())
        {
            if (currentObjectsCount != 2)
            {
                SpawnFurniture(GetFurniturePlaceClicked());
            }
        }
        zoomOutBG.SetActive(true);
    }
  


    public void OnClickFurniture()
    {
        currentFurPlusIcon.SetActive(false);
        if (currentObjectsCount != 2)
        {
            SpawnFurniture(GetFurniturePlaceClicked());
        }
    }

    private Vector2 GetFurniturePlaceClicked()
    {
        Vector2 gridPosition2 = new Vector2(xPosition, yPosition); 
        return gridPosition2;
    }

    public void SpawnFurniture(Vector2 Position)
    {
        furCollider = GetComponent<BoxCollider2D>();
        furCollider.enabled = false;

        GameObject[] uiForClose;
        uiForClose = GameObject.FindGameObjectsWithTag("FurniUI");
        foreach (GameObject i in uiForClose)
        {
            i.SetActive(false);
        }

        currentObjectsCount++;
        GameObject newFurniture = Instantiate(furniture, Position, Quaternion.identity) as GameObject;
        newFurniture.transform.localScale = new Vector2(xScale, yScale);
    }
}
