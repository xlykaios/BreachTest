using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject objectToAppear;

    public void OnButtonClick()
    {
        if (objectToAppear.activeInHierarchy == true)
        {
            objectToAppear.SetActive(true);
        }
        else
        {
            objectToAppear.SetActive(false);
        }
    }
}
