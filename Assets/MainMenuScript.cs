using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenuUI;
    public void PlayGame()
    {

        mainMenuUI.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }
}
