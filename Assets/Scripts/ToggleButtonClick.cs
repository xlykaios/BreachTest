using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonClick : MonoBehaviour
{
    public GameObject objectToToggle;
    private bool isObjectActive = false;
    public float timeToShow = 2f;

    public void OnButtonClick()
    {
        isObjectActive = !isObjectActive; // toggle the state of the object
        objectToToggle.SetActive(isObjectActive); // set the object's active state based on the new value of isObjectActive

        if (isObjectActive)
        {
            StartCoroutine(HideObjectAfterDelay()); // start the coroutine to hide the object after a delay
        }
    }

    IEnumerator HideObjectAfterDelay()
    {
        yield return new WaitForSeconds(timeToShow); // wait for the specified amount of time
        objectToToggle.SetActive(false); // hide the object
        isObjectActive = false; // update the state of the object
    }

    /* if(isObjectActive){
            isObjectActive = !isObjectActive;
            objectToToggle.SetActive(isObjectActive);
            isObjectActive = !isObjectActive;
            objectToToggle.SetActive(isObjectActive);
        }else{
        isObjectActive = !isObjectActive; // toggle the state of the object
        objectToToggle.SetActive(isObjectActive);
        }
    */
}
