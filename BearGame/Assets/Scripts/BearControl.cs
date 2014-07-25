using UnityEngine;
using System.Collections;

public class BearControl : MonoBehaviour 
{
	Animator anim;

	public float movementSpeed = 5.0f;

	private int jumpHeight = 400;
	public bool isGrounded = false;
	
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
				float h = Input.GetAxis ("Horizontal");

				if (h != 0) {

						if (Input.GetKey ("left")) {
								anim.SetBool ("Walking", true);
								transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
						}
						if (Input.GetKey ("right")) {
								anim.SetBool ("Walking", true);
								transform.position += Vector3.right * movementSpeed * Time.deltaTime;
						}
						if (Input.GetButtonDown ("Jump")) {
								anim.SetBool ("Jump", true);
								Jump ();
						}
						
						float sign = Mathf.Sign (h);
						Vector2 scale = transform.localScale;
						scale.x = sign * Mathf.Abs (scale.x);
						transform.localScale = scale;

				} else {
						anim.SetBool ("Walking", false);
						anim.SetBool ("Jump", false);
				}
		}
	void Jump()
	{
		rigidbody2D.AddForce (new Vector2 (0, jumpHeight));
	}
	void FixedUpdate(){
		isGrounded = Physics.Raycast (transform.position, -Vector3.up, .5f);

}
}