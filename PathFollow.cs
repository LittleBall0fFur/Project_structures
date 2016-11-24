using UnityEngine;
using System.Collections;

public class PathFollow : MonoBehaviour {

    public Transform[] path;
    public float speed = 5.0f;
    public float reachDist = 1.0f;
    public int currPoint = 0;
   // Rigidbody body;
    void Start () {
     //   body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 dir =  path[currPoint].position - transform.position;
        float dist = Vector3.Distance(path[currPoint].position, transform.position);
        Vector3 tmpPosition = path[currPoint].position;
        tmpPosition.y = this.transform.position.y;
        transform.position = Vector3.MoveTowards(transform.position, tmpPosition, Time.deltaTime*speed);
        //transform.position += dir * Time.deltaTime * speed;

        if(dist <= reachDist)
        {
            currPoint++;
        }
        if(currPoint >= path.Length)
        {
            currPoint = 0;
        }
        //body.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void onDrawGizmos()
    {   
        if(path.Length > 0)
        {
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] != null)
                {
                    Gizmos.DrawSphere(path[i].position, reachDist);
                }
            }
        }
    }
}
