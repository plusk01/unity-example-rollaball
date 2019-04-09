using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	}

    // Runs every frame, but guaranteed to run after all items have
    // been processed and updated. So when we set position of the camera,
    // we know absolutely that the player has been updated for this frame.
    // Best for "follow cameras, procedural animations, and gathering
    // last known states."
    void LateUpdate () {

    }
}
