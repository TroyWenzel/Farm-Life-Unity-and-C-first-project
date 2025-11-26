using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string LevelToStart;
    private void Start()
    {
        AudioManager.instance.PlayTitle();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(LevelToStart);

        AudioManager.instance.PlayNextBGM();

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }

    public void QuitGame()
    {
        Application.Quit();

        AudioManager.instance.PlaySFXPitchAdjusted(5);
    }

}
