using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.UI;
using System.Net.Mime;


public class BuySlot : MonoBehaviour
{
    public Sprite availableSprite;
    public Sprite unAvailableSprite;

    public bool isAvailable;

    public BuySystem buySystem;

    public int databaseItemID;


    private void Start()
    {
        UpdateAvailabilityUI();
    }

    public void ClickedOnSlot()
    {
        if (isAvailable)
        {
            buySystem.placementSystem.StartPlacement(databaseItemID);
        }
    }


    private void UpdateAvailabilityUI()
    {
        if (isAvailable)
        {
            GetComponent<UnityEngine.UI.Image>().sprite = availableSprite;
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<UnityEngine.UI.Image>().sprite = unAvailableSprite;
            GetComponent<Button>().interactable = true;
        }
    }
}


