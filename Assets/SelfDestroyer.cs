using UnityEngine;
using System.Collections;

public class SelfDestroyer : MonoBehaviour {

    public float timetolive = 5f;
    private float left;
	// Use this for initialization
	void Start () {
        this.left = this.timetolive;
	}
	
	// Update is called once per frame
	void Update () {

        left -= Time.deltaTime;

        if (left < 0) {
            Destroy(this.gameObject);
        }
	}
}
