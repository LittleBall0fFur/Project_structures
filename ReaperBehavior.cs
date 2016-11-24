using UnityEngine;
using System.Collections;

public class ReaperBehavior : MonoBehaviour
{
    public GameObject player;
    public HealthSystem playerHealth;
    public HideSystem hide;
    private Vector3[] currPath;
    private bool reset;
    private int currArrayPosition;
    public float distance;
    public int speed = 5;
    private char direction;
    private bool notAttacking = true;

    void Start()
    {
        
    }
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
        Movement();
        if (notAttacking = true &&  currPath != null)
        {
            if (reset)
            {
                transform.position = currPath[0];
                reset = false;
                currArrayPosition = 1;
                direction = 'u';
            }
            else
            {
                if (Vector3.Distance(currPath[currArrayPosition], transform.position) <= 0.3f && currArrayPosition >= (currPath.Length - 1)) // als de laatste positie gehaald is
                {
                    direction = 'd'; // inverse richting
                }
                else if (Vector3.Distance(currPath[currArrayPosition], transform.position) <= 0.1f && currArrayPosition <= 0) // als de eerste positie gehaald is
                {
                    direction = 'u'; // inverse richting
                }
                if (Vector3.Distance(currPath[currArrayPosition], transform.position) <= 0.1f) // als bestemming gelijk genoeg is aan huidige positie
                {
                    if (direction == 'u') currArrayPosition++; // als richting up is, verhoog positie in array
                    else currArrayPosition--; // als richting down is, verlaag positie in array
                }
           
                transform.position = Vector3.MoveTowards(transform.position, currPath[currArrayPosition], Time.deltaTime * speed);
                if(hide.getHidden() == true && currPath[currArrayPosition] != null)
                {
                    transform.LookAt(currPath[currArrayPosition]);
                }
                else if (player.transform != null)
                {
                    transform.LookAt(player.transform);
                }
            }
        }
    }

    public void Movement()
    {
        if (distance <= 3 && hide.getHidden() == false)
        {
            print("attack");
            notAttacking = false;
            playerHealth.ApplyDamage(2);
            //GetComponent<Animation>().CrossFade("attack");       
        }
        if(distance <= 15 && hide.getHidden() == false && distance >= 3)
        {
            print("run");
            notAttacking = false;
            transform.LookAt(player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.15f);
        }
        notAttacking = true;
    }

    /**
    * Method to switch 
    **/
    public void switchBehaviour(Vector3[] path)
    {
        reset = true;
        currPath = path;
    }
}
