using UnityEngine;
using System.Collections;

public class Skelly_attack : MonoBehaviour {
	public GameObject player;
	public GameObject wanderer;
    public float speed;
	public float distance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("FPSController");
        wanderer = GameObject.Find ("MazeWanderer1");
		distance = Vector3.Distance (player.transform.position, wanderer.transform.position);

		if (distance < 15 &&  distance > 1.0f){
            wanderer.transform.LookAt(player.transform.position);
            wanderer.transform.position = Vector3.MoveTowards (wanderer.transform.position, player.transform.position, speed);
		}	
	}
}
