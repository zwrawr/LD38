using UnityEngine;
using System.Collections;

public class SelfDestroyer : MonoBehaviour {

    public float timetolive = 5f;
    private float left;

    public float distancefromorigin = 10f;
    private float dfo_squared;

	// Use this for initialization
	void Start () {
        this.left = this.timetolive;
        dfo_squared = Mathf.Pow(distancefromorigin, 2f);
	}
	
	// Update is called once per frame
	void Update () {

        left -= Time.deltaTime;

        if (left < 0) {
            doDestroy();
        }

        if (Vector3.SqrMagnitude(this.transform.position) >= dfo_squared) {
            doDestroy();
        }
	}

    private void doDestroy()
    {
        Destroy(this.gameObject);
    }
}
