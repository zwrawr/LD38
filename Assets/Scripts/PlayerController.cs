using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float hoz = 0f;
    public float speed = 1f;

    private GameObject ship;
    public GameObject lazer;

    public float reloadtime = 0.25f;
    private float left;

	// Use this for initialization
	void Start () {

        this.ship = this.GetComponentInChildren<Transform>().gameObject;
        this.left = this.reloadtime;
	}
	
	// Update is called once per frame
	void Update () {

        hoz -= Input.GetAxis("Horizontal");

        if ( Input.GetButton("Fire1") || Input.GetButton("Fire2")  || Input.GetButton("Fire3") ) {
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


        Vector3 dir = this.ship.transform.up * 0.6f;

        Debug.DrawLine(this.transform.position, dir,Color.blue, 10f);

        Debug.Log("Fire : " + dir + " : " + Vector3.Angle(Vector3.up ,dir));

        GameObject tmp = (GameObject)Instantiate(this.lazer, dir, this.ship.transform.rotation);

    }
}
