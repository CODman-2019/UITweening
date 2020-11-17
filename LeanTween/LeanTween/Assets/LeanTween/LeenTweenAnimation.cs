using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenTweenAnimation : MonoBehaviour
{
    public GameObject target_GameObject;

    public GameObject inventory;
    public GameObject map;
    public GameObject stats;

    public GameObject invenButton;
    public GameObject mapButton;
    public GameObject statButton;

    public float curTime;
    public float selTime;

    GameObject currentMenu;
    GameObject selectedMenu;

    Vector3 resetPosition = new Vector3(90f, 0, 0);

    public void ClickMoveButton()
    {
        LeanTween.move(target_GameObject, new Vector3(0, -2f, 0), 2.0f).setEase(LeanTweenType.easeInOutElastic);
        
    }

    public void OpenMenu()
    {
        if (currentMenu == null)
        {
            LeanTween.rotate(selectedMenu, new Vector3(0f, 0, 0), selTime).setEase(LeanTweenType.easeInCubic);
        }
        else
        {
            LeanTween.rotate(currentMenu, new Vector3(-90f, 0, 0), curTime).setEase(LeanTweenType.easeInExpo);
            LeanTween.rotate(selectedMenu, new Vector3(0f, 0, 0), selTime).setEase(LeanTweenType.easeInBack);
            //currentMenu.transform.rotation(resetPosition);
        }
    }

    public void OpenInventory()
    {
        currentMenu = selectedMenu;
        selectedMenu = inventory;

        OpenMenu();
    }

    public void OpenMap()
    {
        currentMenu = selectedMenu;
        selectedMenu = map;
        OpenMenu();
    }

    public void OpenStats()
    {
        currentMenu = selectedMenu;
        selectedMenu = stats;
        OpenMenu();
    }
}
