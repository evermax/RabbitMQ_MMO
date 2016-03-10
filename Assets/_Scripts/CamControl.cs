using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
	private float rotateSpeed = 40.0F;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Fire2"))
		{
			float h = rotateSpeed * Input.GetAxis ("Mouse Y");
			float v  = rotateSpeed * Input.GetAxis ("Mouse X");
			transform.Rotate(v,h,0);
		}
			
	}
}

