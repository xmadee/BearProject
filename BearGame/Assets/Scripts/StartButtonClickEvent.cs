using UnityEngine;
using System.Collections;

public class StartButtonClickEvent : MonoBehaviour 
{
    void OnMouseUpAsButton()
    {
        Application.LoadLevel(1);
    }
}
