using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomNavigation : MonoBehaviour
{
    public int selectedScene;
    public void GotoCustom(){
        SceneManager.LoadScene(selectedScene);
    }
}
