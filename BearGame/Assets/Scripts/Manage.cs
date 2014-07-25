using UnityEngine;
using System.Collections;

public class Manage : MonoBehaviour 
{
	public int HP = 10;
	public float minX = -8;
	public float maxX = 8;
	public float minY = 0;
	public float maxY = 5;
	
	public GameObject HoneyJar;
	public GameObject Poison;
	public GUIText scoreLabel;
	public GUIText HPLabel;
	
	public GameObject dialog;
	public GUIText dialogScoreLabel;
	
	//private int timeCount;
	private int score;
	//private int HP;
	
	// Use this for initialization
	void Start ()
	{
		//HP = 10;
		//InvokeRepeating("UpdateTime", 1, 1);
		InvokeRepeating("MakeHoney", 1, 0.3f);
		InvokeRepeating("MakePoison", 1, 1.8f);
	}
	
	void Update()
	{
		float w = Screen.width;
		float h = Screen.height;
	}

	void MakeHoney()
	{
		float x = Random.Range(minX, maxX);
		
		Vector3 position = new Vector3(x, 6);
		GameObject.Instantiate(HoneyJar, position, Quaternion.identity);
	}

	void MakePoison()
	{
		float xx = Random.Range(minX, maxX);
		float y = Random.Range(minY, maxY);
		
		Vector3 position = new Vector3(xx, y);
		GameObject.Instantiate(Poison, position, Quaternion.identity);
	}
	
	void UpdateScore(int nScore)
	{
		score += nScore;
		scoreLabel.text = "Honey : " + score;
	}

	void UpdateHP(int nHP)
	{
		//HP -= nHP;
		HPLabel.text = "HP : " + (HP -= nHP);

		if (HP <= 0)
		{
			CancelInvoke("MakeHoney");
			CancelInvoke("MakePoison");

			EndGame();
		}
	}
	
	void EndGame()
	{
		dialog.SetActive(true);
		dialogScoreLabel.text = "Honey : " + score;
	}
}
