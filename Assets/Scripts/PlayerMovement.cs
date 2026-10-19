using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera mainCamera;

    private float PlayerSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;

    }

    private void Update()
    {

        int dirx;
        if (Input.touches.Length > 0)
        {
            Vector3 touchPosition = Input.touches[0].position;
            touchPosition = mainCamera.ScreenToWorldPoint(touchPosition);

            if(touchPosition.x > 0)
            {
                //go right
                dirx = 1;
            }
            else
            {
                //go left
                dirx = -1;
            }

        }
    }
}
