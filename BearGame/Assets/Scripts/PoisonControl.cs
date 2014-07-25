using UnityEngine;
using System.Collections;

public class PoisonControl : MonoBehaviour 
{
	private GameObject manager;
	
	void Start()
	{
		manager = GameObject.Find ("Manage");
	}
	
	void OnCollisionEnter2D(Collision2D c) 
	{
		GameObject g = c.gameObject;
		if(g.tag == "Ground")
		{
			CancelInvoke("Poison");
			Destroy (gameObject, 2f);
			Debug.Log ("Explode");
		}
		else if(g.tag == "Bear")
		{
			CancelInvoke("Poison");
			Sick();
		}
	}
	
	void Sick()
	{
		manager.SendMessage ("UpdateHP", 1, SendMessageOptions.DontRequireReceiver);
		
		Debug.Log ("Sick");
		Destroy (gameObject);
	}
	
}
