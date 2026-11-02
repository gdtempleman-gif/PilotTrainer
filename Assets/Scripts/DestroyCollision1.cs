using UnityEngine;

public class DestroyCollision1 : MonoBehaviour
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
        if (collision.gameObject.CompareTag("BObject"))// checks if you collide with the enemy to trigger the if statament
        {
            Destroy(collision.gameObject);
        }
    }
}
