using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    int currentHealth = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage();
            Debug.Log("Damage check");
        }
      
        
    }
    public void TakeDamage()
    {
        currentHealth -= 1;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
