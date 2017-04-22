using UnityEngine;
using System.Collections;

public class LazerController : MonoBehaviour {

    public float speed = 5f;

	void Start () {
	
	}
	
	void FixedUpdate () {
        Vector3 pos = this.transform.position;

        pos =  pos + (this.transform.up * this.speed * Time.deltaTime);

        this.transform.position = pos;
	}
}

