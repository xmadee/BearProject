using UnityEngine;
using System.Collections;

public class MeuButtonClickEvent : MonoBehaviour 
{

    void OnMouseUpAsButton()
    {
        Application.LoadLevel(0);
    }
}
