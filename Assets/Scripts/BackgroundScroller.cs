using Unity.VisualScripting;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 3f;
    private float backgroundHeight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgroundHeight = GetComponent<SpriteRenderer>().bounds.size.y;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        if(transform.position.y < -backgroundHeight)
        {
            transform.position += Vector3.up * backgroundHeight * 2f;
        }
        
    }
}
