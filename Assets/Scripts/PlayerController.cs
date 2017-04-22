using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float hoz = 0f;
    public float speed = 1f;

    private GameObject ship;
    public GameObject lazer;

    public float reloadtime = 0.25f;
    private float left;


    public int numGuns = 1;
	// Use this for initialization
	void Start () {

        this.ship = this.GetComponentInChildren<Transform>().gameObject;
        this.left = this.reloadtime;
	}
	
	// Update is called once per frame
	void Update () {

        hoz -= Input.GetAxis("Horizontal");

        if ( Input.GetButton("Fire1") || Input.GetButton("Fire2")  || Input.GetButton("Fire3") || Input.GetButton("Fire4") ) {
            if (left < 0)
            {
                Fire();
                this.left = this.reloadtime;
            }
        }

        this.left -= Time.deltaTime;
	}

    void FixedUpdate () {

        Vector3 rot = this.transform.rotation.eulerAngles;

        rot.z += hoz * speed * Time.deltaTime;
        hoz = 0f;

        this.transform.rotation = Quaternion.Euler(rot);

    }

    private void Fire() {


        Vector3 dir = this.ship.transform.up * 0.7f; //hardcoded distance betweeen player and planet

        if (this.numGuns == 1 || this.numGuns == 3 || this.numGuns == 5)
        {
            Instantiate(this.lazer, dir, this.ship.transform.rotation);
        }

        var perp = Vector3.Cross(Vector3.forward, dir);

        if (this.numGuns == 2 || this.numGuns == 3 || this.numGuns == 4 || this.numGuns == 5)
        {
            var left =  dir * 0.9f + perp.normalized * 0.075f;
            var right = dir * 0.9f - perp.normalized * 0.075f;

            Instantiate(this.lazer, left, this.ship.transform.rotation);
            Instantiate(this.lazer, right, this.ship.transform.rotation);
        }

        if (this.numGuns == 4 || this.numGuns == 5) {
            var left = dir * 0.95f + perp.normalized * 0.035f;
            var right = dir * 0.95f - perp.normalized * 0.035f;

            Instantiate(this.lazer, left, this.ship.transform.rotation);
            Instantiate(this.lazer, right, this.ship.transform.rotation);
        }

    }
}
