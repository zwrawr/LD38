using UnityEngine;
using System.Collections;

public class LazerController : MonoBehaviour {

    public float speed = 5f;

    public float rnd_max = 1f;

	void Start () {
        float rnd = Random.Range(-rnd_max, rnd_max);

        var rot = this.transform.rotation;
        rot.z += rnd;
        this.transform.rotation = rot;
	}
	
	void FixedUpdate () {
        Vector3 pos = this.transform.position;

        pos =  pos + (this.transform.up * this.speed * Time.deltaTime);

        this.transform.position = pos;
	}
}

