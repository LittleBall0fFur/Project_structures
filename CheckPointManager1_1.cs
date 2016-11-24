using UnityEngine;
using System.Collections;

public class CheckPointManager1_1 : MonoBehaviour {

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "Player")
        {
            GameObject.Find("PathFinding").GetComponent<PathFinder>().setPath1_1();
        }
    }
}
