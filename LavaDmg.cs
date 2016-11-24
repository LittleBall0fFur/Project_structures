using UnityEngine;
using System.Collections;

public class LavaDmg : MonoBehaviour {
    public HealthSystem player;
    private bool inTrigger;

    public void Update()
    {
        if (inTrigger)
        {
            player.ApplyDamage(1);
        }
    }

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "Player")
        {
            inTrigger = true;
            print("enter");
        }
    }
    public void OnTriggerExit(Collider player)
    {
        inTrigger = false;
        print("exit");
    }
}
