using UnityEngine;
using System.Collections;

public class CheckpointManager2 : MonoBehaviour {

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "Player")
        {
            GameObject.Find("PathFinding").GetComponent<PathFinder>().setPath2();
        }
    }
}
