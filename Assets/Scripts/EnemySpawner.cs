using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {


    public GameObject Enemy;

    public float init_delay = 5f;
    public float min_delay = 0.025f;

    public float scaler = 0.1f;

    float delay;
    float left = 0f;

    public float spawndistance = 15f;

    // Use this for initialization
    void Start() {
        delay = init_delay;
    }

    // Update is called once per frame
    void Update() {
        if (left <= 0f)
        {

            delay = Mathf.Lerp(delay, min_delay,  scaler);

            left = delay;

            spawnEnemy();
        }

        left -= Time.deltaTime;
    }

    void FixedUpdate() {

    }

    void spawnEnemy() {

        Vector3 pos = Random.insideUnitCircle.normalized * spawndistance;

        GameObject tmp = (GameObject)Instantiate(Enemy, pos, Quaternion.identity, this.transform);

    }
}
