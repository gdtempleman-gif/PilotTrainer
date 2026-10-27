using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    int currentHealth = 3;
    public TMP_Text healthText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))// this is to test the damage and death system 
        {
            TakeDamage();
            Debug.Log("Damage check");// to let me know if the damage input is working and damage should be triggered
        }
      
        
    }
    public void TakeDamage()
    {
        currentHealth -= 1;

        if (currentHealth <= 0)// This checks if you meet the parameters of being 0 health or lower
        {
            SceneManager.LoadScene("GameOver");// This takes you to the gameover scene
        }
        healthText.text = "Health: " + currentHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))// checks if you collide with the enemy to trigger the if statament
        {
            TakeDamage();// causes you to take damage
        }
    }

    

}
