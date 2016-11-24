using UnityEngine;
using System.Collections;

public class LavaDamage : MonoBehaviour {
    public HealthSystem player;
    private bool inTrigger;
    float timer = 0.0f;

    public void Update()
    {
        if (inTrigger)
        {
            timer += Time.deltaTime;
            if(timer >= 0.5f)
            {
                player.ApplyDamage(5);
                timer = 0f;
            }
        }
    }

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }
    public void OnTriggerExit(Collider player)
    {
        inTrigger = false;
    }
}
