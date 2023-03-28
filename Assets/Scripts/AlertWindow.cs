using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class AlertWindow : MonoBehaviour
{
    public GameObject alertWindow;

    public void ShowAlertWindow()
    {
        alertWindow.SetActive(true);
    }

    public void HideAlertWindow()
    {
        alertWindow.SetActive(false);
    }
}

