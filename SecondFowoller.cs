using UnityEngine;
using System.Collections;

public class ControllSphereChildTwo : MonoBehaviour
{

	// Update is called once per frame
	public float speed = 2.4f;
	public Transform secondSphere;
	
	void Update () 
	{
		transform.LookAt (secondSphere.position);
		

		float dist = Vector3.Distance (transform.position, secondSphere.position);
		if (dist > 3)
		{
			transform.Translate (0f,0f,speed * Time.deltaTime);
		}

	}
}
