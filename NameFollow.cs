using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class NameFollow : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshPro ftext;
    public GameObject noUsernameCheck;
    public GameObject SetUsernamePanel;
    public bool isClicked = false;
    void Start()
    {
    }

    public void OnButtonClicked()
    {
       if(username.text == ""){
            isClicked = false;
            print("Nope");
            SetUsernamePanel.SetActive(true);
            noUsernameCheck.SetActive(true);
        } else if (username.text != ""){
            isClicked = true;
            ftext.text = username.text;
            print("yup");
            SetUsernamePanel.SetActive(false);
            noUsernameCheck.SetActive(true);
        }
    }
}