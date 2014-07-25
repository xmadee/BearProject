using UnityEngine;
using System.Collections;

public class QuitButtonClickEvent : MonoBehaviour 
{
    void OnMouseUpAsButton()
    {
        Application.Quit();
    }
}

