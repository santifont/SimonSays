using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject[] buttons;
    TextMeshProUGUI mainText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttons = GameObject.FindGameObjectsWithTag("Button");
        mainText = GameObject.Find("MainText").GetComponent<TextMeshProUGUI>();
        StartCoroutine(SimonSays());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SimonSays()
    {
        CanvasOff();
        // Welcome message
        mainText.text = "Welcome, player from outside this world.";
        yield return new WaitForSeconds(2f);
        mainText.text = "Get ready for a fierce battle against the computer in\n Simon Says";
        yield return new WaitForSeconds(2f);

        CanvasOn();
        mainText.text = "Player's turn!";
        yield return null;

    }

    private void CanvasOn()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(true);
        }
    }

    private void CanvasOff()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
