using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSystem : MonoBehaviour
{

    public void OnStartTouch()// this loads the specific scene when play button is pressed
    {
        SceneManager.LoadScene("Play Area");
    }

    public void OnBriefingTouch()// this loads the specific scene when the credit button is clicked
    {
        SceneManager.LoadScene("Briefing");
    }

    public void OnHelpTouch()// this loads the specific scene when the the help button is clicked
    {
        SceneManager.LoadScene("Help");
    }

    public void OnReturnTouch()// this returns to main menu when clicked
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void OnExitTouch() // this closed the application when used in unity and or its on load
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
    
}