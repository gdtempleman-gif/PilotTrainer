using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Camera mainCamera;

    [SerializeField]private float PlayerSpeed = 50f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;

    }

    private void Update(int dirX)
    {
        if(Application.isEditor)
        {
          
        }
        else
        {
            if (Input.touches.Length > 0)
            {
                Vector3 touchPosition = Input.touches[0].position;
                touchPosition = mainCamera.ScreenToWorldPoint(touchPosition);

                if (touchPosition.x > 0)
                {
                    //go right
                    dirX = 1;
                }
                else
                {
                    //go left
                    dirX = -1;
                }

            }

        }


        

        rb.linearVelocity = new Vector2(dirX * PlayerSpeed * Time.deltaTime, 0);
    }
}
