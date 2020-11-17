using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonTweening : MonoBehaviour
{

    private void OnMouseOver()
    {
         LeanTween.scale(this.gameObject, new Vector3(1.5f, 1.5f, 0), 3f).setEase(LeanTweenType.easeInBounce);
         LeanTween.scale(this.gameObject, new Vector3(1f, 1f, 0), 3f).setEase(LeanTweenType.easeOutBounce);
    }
}
