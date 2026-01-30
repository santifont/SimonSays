using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject[]    buttons;
    TextMeshProUGUI mainText;
    string[] coloursArray = {"Red", "Green", "Blue", "Yellow"};
    int round    = 1;
    int maxRounds = 10;
    int[] colorOrder = new int[11]; // Index 0 is not used, it's from 1 to 10 only. Not 0 to 10!!!
    bool game = true;
    bool turn = true; // true -> player, false -> ai

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttons  = GameObject.FindGameObjectsWithTag("Button");
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
        yield return new WaitForSeconds(1f);
        mainText.text = "Get ready for a fierce battle against the computer in" + "\n Simon Says";
        yield return new WaitForSeconds(1f);
        mainText.text = "This game will take " + maxRounds + " rounds.";
        yield return new WaitForSeconds(1f);
        while (game = true)
        {
            // Player's turn
            mainText.text = "Player's turn!" + "\n Round " + round;
            CanvasOn();
            while (turn == true)
            {
                yield return null;
            }
            CanvasOff();
            mainText.text = "The AI will repeat" + "\nall the colours you chose";
            yield return new WaitForSeconds(2f);

            for (int i = round;  i <= maxRounds; i++)
            {

            }
        }
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

    public void Red()
    {
        Debug.Log("Red");
        //colorArray[0];
        colorOrder[round] = 0;
        turn = false;
    }

    public void Green()
    {
        Debug.Log("Green");
        //colorArray[1];
        colorOrder[round] = 1;
        turn = false;
    }

    public void Blue()
    {
        Debug.Log("Blue");
        //colorArray[2];
        colorOrder[round] = 2;
        turn = false;
    }

    public void Yellow()
    {
        Debug.Log("Yellow");
        //colorArray[3];
        colorOrder[round] = 3;
        turn = false;
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
