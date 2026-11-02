using UnityEngine;
using TMPro;

public class SurvivalTimer : MonoBehaviour
{
    public float survivalTime = 0f; // Variable for the time the player has survived
    public TMP_Text survivalTimeText; // Reference to the TMP_Text component for displaying survival time

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        survivalTime += Time.deltaTime; // Increment the survival time by the time elapsed since the last frame
        survivalTimeText.text = "Survival Time: " + Mathf.FloorToInt(survivalTime) + "s"; // Update the text to show the survival time in seconds   

    }

    public void SaveSurvivalTime()
    {
        PlayerPrefs.SetFloat("SurvivalTime", survivalTime); // Save the survival time to PlayerPrefs
        PlayerPrefs.Save(); // Ensure the data is written to disk
    }
}
