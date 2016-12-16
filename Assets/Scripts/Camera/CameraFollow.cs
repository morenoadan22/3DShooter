using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		//Calculate the initial offset
		offset = transform.position - target.position;		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 targetCamPosition = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPosition, smoothing * Time.deltaTime);
	}
}
