using UnityEngine;
using System.Collections;

public class HideCollider : MonoBehaviour {

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "Player")
        {
            print("hidden");
            GameObject.Find("FPSController").GetComponent<HideSystem>().setHiddenTrue();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("FPSController").GetComponent<HideSystem>().setHiddenFalse();
        }
    }
}
