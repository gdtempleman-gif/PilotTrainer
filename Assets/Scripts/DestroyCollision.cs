using UnityEngine;

public class DestroyCollision : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Enemy"))// checks if you collide with the enemy to trigger the if statament
        {
            Destroy(collision.gameObject);
        }
    }
}
