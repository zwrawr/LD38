using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{

    public float health = 100f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

        DamageDealer DD = collision.transform.GetComponentInParent<DamageDealer>();

        if (DD != null) {
            float damage = DD.damage;

            this.health -= damage;

            if (this.health <= 0)
            {
                Debug.Log("Was killed by " + DD.transform.name);
                Destroy(this.gameObject);
            }

            DD.didDamage(this.gameObject);
        }
    }
}
