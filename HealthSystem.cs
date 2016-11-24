using UnityEngine;
using System.Collections;


public class HealthSystem : MonoBehaviour {
    public float maxHealth;
    public float currentHealth;
    float timer = 0.0f;

    public BarScript bar;

    // Use this for initialization
    void Start () {
        currentHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
        DeathCheck();
        HealthbarUpdate();
        Regeneration();
    }

    private void DeathCheck()
    {
        if (currentHealth <= 0)
        {
            //Return to menu
            currentHealth = 0;
            print("game over");
        }
    }

    private void HealthbarUpdate()
    {
        bar.Value = currentHealth;
        bar.MaxValue = maxHealth;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        //healthbar.GetComponent<GUIText> ().text = "Health:" + currentHealth + " /100";
    }

    public void ApplyDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }

    public void Regeneration()
    {
        if(currentHealth < maxHealth)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 5.0f)
        {
            currentHealth += 2;
            timer = 0f;
        }
    }
}
