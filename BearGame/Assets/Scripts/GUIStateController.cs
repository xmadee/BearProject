using UnityEngine;
using System.Collections;

public class GUIStateController : MonoBehaviour 
{
    private GUITexture gui;

    public Texture normal, down;

	// Use this for initialization
	void Start () 
    {
        gui = GetComponent<GUITexture>();
	}

    void OnMouseDown()
    {
        gui.texture = down;
    }

    void OnMouseUp()
    {
        gui.texture = normal;
    }

}
