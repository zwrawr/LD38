using UnityEngine;
using System.Collections;

public class DamageDealer : MonoBehaviour {

    public float damage = 10f;

    public void didDamage(GameObject other) {
        Debug.Log("Did damage to " + other.transform.name);
        Destroy(this.gameObject);
    }

}
