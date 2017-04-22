using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour
{
    public float health = 100f;
    protected float init_health;

    // Use this for initialization
    void Start()
    {
        this.init_health = this.health;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision : between [" + this.transform.name + "] and [" + collision.transform.name + "]");

        DamageDealer DD = collision.transform.GetComponentInParent<DamageDealer>();

        if (DD == null) {
            DD = collision.transform.GetComponent<DamageDealer>();
        }

        if (DD != null) {
            TakeDamage(DD.damage);


            if (this.health <= 0)
            {
                Die(DD.transform.name);
            }

            DD.didDamage(this.gameObject);
        }
    }

    protected virtual void TakeDamage(float d)
    {
        this.health -= d;
    }

    protected virtual void Die(string by) {
        Debug.Log("Was killed by " + by);
        Destroy(this.gameObject);
    }


}
