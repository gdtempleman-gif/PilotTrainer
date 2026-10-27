using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemySpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * EnemySpeed * Time.deltaTime;// sets the speed of the enemy falling down the screen and makes him move
    }


}
