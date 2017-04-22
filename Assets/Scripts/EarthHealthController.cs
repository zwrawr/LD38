using UnityEngine;
using System.Collections;

public class EarthHealthController : HealthController {

    private EarthHealthDisplayController ehdc;
    public GameObject GO;


    protected override void Die(string by) {
        GameOver();
    }

    protected override void TakeDamage(float d)
    {
        this.health -= d;
        updateHealthInfo();
    }


    void GameOver() {
        Debug.Log("GAME OVER");

        GO.SetActive(true);
    }



    void updateHealthInfo() {

        if (ehdc == null)
        {
            ehdc = GameObject.FindObjectOfType<EarthHealthDisplayController>();
        }

        Debug.Log("Earth health = " + this.health + " / " + this.init_health);
        ehdc.setHealthPercentage(this.health / this.init_health);
    }
}
