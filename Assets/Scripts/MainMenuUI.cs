using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] TMP_Text exitButton;
    [SerializeField] TMP_Text startButton;

    private bool buttonState;

    void Start()
    {
        InvokeRepeating("SwapButton", 1, 2);
    }

    void SwapButton()
    {
        if (buttonState)
        {
            buttonState = false;
            exitButton.text = "sTaRt";
            startButton.text = "eXiT";
        }
        else
        {
            buttonState = true;
            exitButton.text = "eXiT";
            startButton.text = "sTaRt";
        }
    }


    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Level1");
    }


    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
