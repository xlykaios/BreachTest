
using UnityEngine;
using UnityEngine.UI;

public class ShowHideText : MonoBehaviour
{
    public Image imgtest;
    public Button button;
    private bool switchText = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeText()
    {

        switchText = !switchText;


        if (switchText)
        {
            imgtest.enabled = true;
        }
        else
        {
            imgtest.enabled = false;
        }
    }
}
