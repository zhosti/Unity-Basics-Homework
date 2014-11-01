using UnityEngine;
using System.Collections;

public class ControllSphere : MonoBehaviour {
	
	// Update is called once per frame
	public bool isMove = false;
	public float speed = 3.0f; 
	void Update () 
	{

		if (Input.GetKey (KeyCode.UpArrow)) 
		{ 
			transform.Translate (0f, 0f, speed * Time.deltaTime); 
			isMove = true;
		} 
		else if (Input.GetKey (KeyCode.DownArrow))
		{
			transform.Translate (0f, 0f, -speed * Time.deltaTime);
			isMove = true;
		} 
		else if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(-speed*Time.deltaTime, 0f, 0f); 
		} 
		else if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate(speed*Time.deltaTime, 0f, 0f); 
		}
		else if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (0f, speed * Time.deltaTime, 0f);
			isMove = true;
		} 
		else if (Input.GetKey (KeyCode.D))
		{
			transform.Translate (0f, -speed * Time.deltaTime, 0f); 	
			isMove = true;
		}  
		else 
		{
			isMove = false; 
		}
	}
}
