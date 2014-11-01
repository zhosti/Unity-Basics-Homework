using UnityEngine;
using System.Collections;

public class ControllSphereChildOne : MonoBehaviour 
{


	// Update is called once per frame
	public float speed = 2.7f;
	public Transform firstSphere;

	void Update () 
	{
		transform.LookAt (firstSphere.position);
	

		float dist = Vector3.Distance (transform.position, firstSphere.position);
		if (dist > 3)
		{
			transform.Translate (0f,0f,speed * Time.deltaTime);
		}

	}
}
