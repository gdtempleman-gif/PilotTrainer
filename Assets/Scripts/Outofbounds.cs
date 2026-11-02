using UnityEngine;

public class Outofbounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.CompareTag("Bobject"))// checks if you collide with the Bobject(BackgroundObject) to trigger the if statament
        {
            Destroy(collision.gameObject);
        }

    }
}
