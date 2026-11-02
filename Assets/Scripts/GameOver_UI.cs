using UnityEngine;
using TMPro;

public class GameOver_UI : MonoBehaviour
{
    public TMP_Text SurvivalTimeText; // Reference to the TMP_Text component for displaying survival time
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float finalTime = PlayerPrefs.GetFloat("SurvivalTime", 0f); // Retrieve the survival time from PlayerPrefs

        Debug.Log("Final Survival Time: " + finalTime); // Log the final survival time for debugging and testing to show action is takeing place in console

        int minutes = Mathf.FloorToInt(finalTime / 60f); // Calculate minutes from total seconds

        int seconds = Mathf.FloorToInt(finalTime % 60f); // Calculate remaining seconds

        SurvivalTimeText.text = $"Survival Time:  {minutes:00}:{seconds:00}"; // Update the text to show the formatted survival time
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
