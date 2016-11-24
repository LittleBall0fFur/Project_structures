﻿using UnityEngine;
using System.Collections;

public class CheckPointManager3_2 : MonoBehaviour {

    public void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "Player")
        {
            GameObject.Find("PathFinding").GetComponent<PathFinder>().setPath3_2();
        }
    }
}
