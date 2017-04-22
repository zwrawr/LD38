using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public Vector3 Target;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = this.transform.position;


        //this.transform.LookAt(Target,Vector3.up);


        this.transform.position = Vector3.MoveTowards(pos, Target, speed * Time.deltaTime);

	}
}
