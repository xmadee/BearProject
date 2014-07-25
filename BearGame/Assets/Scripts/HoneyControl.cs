using UnityEngine;
using System.Collections;

public class HoneyControl : MonoBehaviour 
{
	private GameObject manage;
	
	void Start()
	{
		manage = GameObject.Find ("Manage");
	}
	
	void OnCollisionEnter2D(Collision2D c) 
	{
		GameObject g = c.gameObject;
		if(g.tag == "Ground")
		{
			CancelInvoke("HoneyJar");
			Destroy (gameObject, 0.2f);
			Debug.Log ("Explode");
		}
		else if(g.tag == "Bear")
		{
			CancelInvoke("HoneyJar");
			Collect();
		}
	}
	
	void Collect()
	{
		manage.SendMessage ("UpdateScore", 1, SendMessageOptions.DontRequireReceiver);
		
		Debug.Log ("Collect");
		Destroy (gameObject);
	}
	
}