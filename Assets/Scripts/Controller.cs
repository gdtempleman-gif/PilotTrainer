using System.Security.Cryptography;
using UnityEngine;

public class Controller : MonoBehaviour
{
 public float TapThreshold = 10f;
public float SwipeThreshold = 50f;

    public float LeftLaneX  = -2.5f;
    public float MiddleLaneX = 0f;
    public float RightLaneX = 2.5f;

    private float TargetLaneX;

private Vector2 startTouchPosition;

    private int CurrentLane = 1; // 0 = Left, 1 = Middle, 2 = Right

    private void Update()
    {
        if (Input.touchCount > 0)// Check if there are any touches
        {
         

            Touch touch = Input.GetTouch(0);// Gets the first touch
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startTouchPosition = touch.position;// Store the starting position of the touch
                    break;
                case TouchPhase.Ended:
                    Vector2 endTouchPosition = touch.position;// Store the ending position of the touch
                    Vector2 swipeDelta = endTouchPosition - startTouchPosition;// Calculate the swipe delta
                    if (swipeDelta.magnitude < TapThreshold)// Check if the swipe delta is less than the tap threshold
                    {
                        // Handle tap
                        Debug.Log("Tap detected");
                    }
                    else if (swipeDelta.magnitude >= SwipeThreshold)// Check if the swipe delta is greater than or equal to the swipe threshold
                    {
                        // Handle swipe
                        if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))// Check if the swipe is more horizontal than vertical
                        {
                            if (swipeDelta.x > 0)
                            {
                                Debug.Log("Swipe Right detected");
                                CurrentLane = Mathf.Min(CurrentLane + 1, 2); // Moves you to the right lane, but stops you from going past the right lane
                            }
                            else
                            {
                                Debug.Log("Swipe Left detected");
                                CurrentLane = Mathf.Max(CurrentLane - 1, 0); // Moves you to the left lane, but stops you from going past the left lane
                            }
                            if (CurrentLane == 0)
                            {
                                TargetLaneX = LeftLaneX;
                            }
                            else if (CurrentLane == 1)
                            {
                                TargetLaneX = MiddleLaneX;
                            }
                            else if (CurrentLane == 2)
                            {
                                TargetLaneX = RightLaneX;
                            }// Update the target lane to the right lane, middle lane, or left lane based on the current lane


                        }
                        else
                        {
                            if (swipeDelta.y > 0)
                            {
                                Debug.Log("Swipe Up detected");

                            }
                            else
                            {
                                Debug.Log("Swipe Down detected");
                            }// this is for when i want to add lanes forward so you can dodge attacks that come from the side , but this is for later development.


                        }
                    }
                    break;
            }

            float newX = Mathf.MoveTowards(
                transform.position.x,
                TargetLaneX,
                5f * Time.deltaTime);//this states that the player should move its current position to the target lane selected


            transform.position = new Vector3(newX,
                transform.position.y,
                transform.position.z);// this is what will actually effect the players possition
           
        }
    }
}// update check
