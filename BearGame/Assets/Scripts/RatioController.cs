using UnityEngine;
using System.Collections;

public class RatioController : MonoBehaviour 
{
    public Vector2 aspectRatio;

    // Use this for initialization
    void Start()
    {
        camera.aspect = aspectRatio.x / aspectRatio.y;
    }
}
