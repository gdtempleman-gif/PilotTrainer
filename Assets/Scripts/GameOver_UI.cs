using UnityEngine;
using TMPro;

public class GameOver_UI : MonoBehaviour
{
    public TMP_Text SurvivalTimeText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.GetFloat("SurvivalTime");// Gets the saved time
        float finalTime = PlayerPrefs.GetFloat("Timed Survival: ");
        int minutes = Mathf.FloorToInt(finalTime / 60f);// Gets the minuteslasted
        int seconds = Mathf.FloorToInt(finalTime % 60f);// Gets the remeinder seconds after minutes 

        SurvivalTimeText.text = $"Time Survived: {minutes:00}:{seconds:00}";// Displays the time survived and tags the values to be drawn from
        Debug.Log("Time brough over" + finalTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
                                                                                                           