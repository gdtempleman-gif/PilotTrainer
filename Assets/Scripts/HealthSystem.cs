
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;
using UnityEditor;

public class HealthSystem : MonoBehaviour
{
    int currentHealth = 3;
    public TMP_Text healthText;
    public SurvivalTimer survivalTimer;


    bool isRolling = false;// this is to check if the player is rolling or not, if they are rolling they will not take damage
    bool canRoll = true; // This will check if the payer can press the roll button again or not
    public float rollCooldown = 5f; // The cooldown time for rolling
    public AnimationClip roll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.H))// this is to test the damage and death system 
       // {
         //   TakeDamage();
         // Debug.Log("Damage check");// to let me know if the damage input is working and damage should be triggered
       // }
      
        
    }
    public void TakeDamage()
    {
        currentHealth -= 1;

        if (currentHealth <= 0)// This checks if you meet the parameters of being 0 health or lower
        {
            survivalTimer.SaveSurvivalTime();// This saves the survival time to the playerprefs so it can be displayed in the gameover scene

            SceneManager.LoadScene("GameOver");// This takes you to the gameover scene
        }
        healthText.text = "Health: " + currentHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isRolling)// checks if you collide with the enemy and if the player is rolling so it knows to trigger the if statament
        {
            TakeDamage();// causes you to take damage
        }
    }

    public void StartRoll()
    {
        if(canRoll)
        {
            canRoll = false; // This sets the canRoll state to false to prevent rolling again during cooldown

            StartCoroutine(Roll()); // This starts the roll coroutine
          
            StartCoroutine(RollCooldown()); // This starts the roll cooldown coroutine
        }

    }

    IEnumerator Roll() 
    { 
        isRolling = true;// This is to set the rolling state to true when the roll starts

        yield return new WaitForSeconds(2.5f); // This is the duration of the roll 

        isRolling = false;// This is to set the rolling state back to false after the roll is complete

    }

    IEnumerator RollCooldown()
    {
       yield return new WaitForSeconds(rollCooldown); // This is the cooldown time for rolling

        canRoll = true; // This is to set the canRoll state back to true after the cooldown is complete
    }


}
