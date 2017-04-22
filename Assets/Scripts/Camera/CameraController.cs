using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float zoom_speed = 0.01f;
    private float init_zoom;

    private Camera cam;
	// Use this for initialization
	void Start () {
        this.cam = this.GetComponent<Camera>();

        this.init_zoom = cam.orthographicSize;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        this.cam.orthographicSize += zoom_speed * Time.deltaTime;

	}
}
