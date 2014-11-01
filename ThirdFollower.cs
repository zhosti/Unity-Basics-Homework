using UnityEngine;
using System.Collections;

public class ControllSphereChildThree : MonoBehaviour
{

	
	// Update is called once per frame


		public float speed = 2.1f;
		public Transform thirdSphere;
		
		void Update () 
		{
			transform.LookAt (thirdSphere.position);
			
			float dist = Vector3.Distance (transform.position, thirdSphere.position);
			if (dist > 3)
			{
				transform.Translate (0f,0f,speed * Time.deltaTime);
			}

			
		}
}
