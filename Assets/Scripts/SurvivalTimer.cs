using UnityEngine;
using TMPro;
using System.Collections;

public class SurvivalTimer : MonoBehaviour
{
    public static SurvivalTimer Instance;
    public TMP_Text TimeText;
    public float SurvivalTime = 0f;// sets the base survival time
    float BestTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        SurvivalTime += Time.deltaTime;

        TimeText.text = "Timed Survival: " + Mathf.FloorToInt(SurvivalTime) + " Seconds";
        if (SurvivalTime > BestTime)
        {
           // PlayerPrefs.Save(BestTime);
        }

    }

    public void SaveSurvivalTime()
    {
        PlayerPrefs.SetFloat("Timed Survival: ", SurvivalTime);
        Debug.Log("Saved the time: " + SurvivalTime);
       // PlayerPrefs.Save("Best Time: " + BestTime + " Seconds");

    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
    }
}
