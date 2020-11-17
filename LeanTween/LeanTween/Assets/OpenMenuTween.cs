using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenuTween : MonoBehaviour
{
    public GameObject menuButtons;

    bool open;

    // Start is called before the first frame update
    void Start()
    {
        open = true;
    }

    public void OpenMenu()
    {
        if (open)
        {
            open = false;

            LeanTween.move(menuButtons, new Vector3(300f, 455f, 0), 3).setEase(LeanTweenType.easeInBack);
        }
        else if (!open)
        {
            open = true;

            LeanTween.move(menuButtons, new Vector3(895f, 455f, 0), 3).setEase(LeanTweenType.easeInBack);
        }
    }
}
