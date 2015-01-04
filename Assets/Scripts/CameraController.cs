using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Follow Cameras, Procedural Animation, Get Last Known States
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
