using UnityEngine;
using System.Collections;

public class PathFinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
    /**
    * Method to set the first path of the reaper
    * @return Gameobject[]: Array containing starter position (0) and checkpoints to go (1-3)
    **/
	public void setPath1()
    {
        Vector3[] nodes = new Vector3[7];
        nodes[0] = GameObject.Find("PathStartOne").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path1_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path1_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path1_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path1_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path1_5").GetComponent<Transform>().position;
        nodes[6] = GameObject.Find("Path1_6").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath1_1()
    {
        Vector3[] nodes = new Vector3[5];
        nodes[0] = GameObject.Find("StartPoint1_1").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path1_1_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path1_1_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path1_1_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path1_1_4").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath1_3()
    {
        Vector3[] nodes = new Vector3[4];
        nodes[0] = GameObject.Find("StartPoint1_3").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path1_3_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path1_3_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path1_3_3").GetComponent<Transform>().position;


        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath2()
    {
        Vector3[] nodes = new Vector3[6];
        nodes[0] = GameObject.Find("PathStartTwo").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path2_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path2_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path2_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path2_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path2_5").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath2_1()
    {
        Vector3[] nodes = new Vector3[6];
        nodes[0] = GameObject.Find("PathStartTwo").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path2_2_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path2_2_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path2_2_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path2_2_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path2_2_5").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }
    public void setPath2_2()
    {
        Vector3[] nodes = new Vector3[7];
        nodes[0] = GameObject.Find("StartPoint2_1").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path2_3_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path2_3_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path2_3_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path2_3_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path2_3_5").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path2_3_6").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath3()
    {
        Vector3[] nodes = new Vector3[7];
        nodes[0] = GameObject.Find("PathStart3").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path3_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path3_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path3_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path3_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path3_5").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path3_6").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath3_1()
    {
        Vector3[] nodes = new Vector3[7];
        nodes[0] = GameObject.Find("PathStart3_1").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path_3_1_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path_3_1_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path_3_1_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path_3_1_4").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path_3_1_5").GetComponent<Transform>().position;
        nodes[5] = GameObject.Find("Path_3_1_6").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }

    public void setPath3_2()
    {
        Vector3[] nodes = new Vector3[5];
        nodes[0] = GameObject.Find("PathStart3_2").GetComponent<Transform>().position;
        nodes[1] = GameObject.Find("Path3_2_1").GetComponent<Transform>().position;
        nodes[2] = GameObject.Find("Path3_2_2").GetComponent<Transform>().position;
        nodes[3] = GameObject.Find("Path3_2_3").GetComponent<Transform>().position;
        nodes[4] = GameObject.Find("Path3_2_4").GetComponent<Transform>().position;

        GameObject.Find("Reaper").GetComponent<ReaperBehavior>().switchBehaviour(nodes);
    }
}
