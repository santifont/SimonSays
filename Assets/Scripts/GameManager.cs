using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject[]    buttons;
    TextMeshProUGUI mainText;
    string[] colorArray = new string[21]; // 1 - 20 = 0 excluded
    int counter = 0;
    int repeat = 1;
    private GameObject titleCanvas;
    private GameObject mainCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        titleCanvas = GameObject.Find("TitleScreen");
        mainCanvas  = GameObject.Find("Canvas");
        buttons     = GameObject.FindGameObjectsWithTag("Button");
        mainText    = GameObject.Find("MainText").GetComponent<TextMeshProUGUI>();

        mainCanvas.SetActive(false);

    }

    // Update is called once per frame

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
        counter++;
        if (counter < 21)
        {
            colorArray[counter] = "Red";
        }
        if (counter > 20)
        {
            counter = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Red" + " " + counter);
    }

    public void Green()
    {
        counter++;
        if (counter < 21)
        {
            colorArray[counter] = "Green";
        }
        if (counter > 20)
        {
            counter = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Green" + " " + counter);
    }

    public void Blue()
    {
        counter++;
        if (counter < 21)
        {
            colorArray[counter] = "Blue";
        }        
        if (counter > 20)
        {
            counter = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Blue" + " " + counter);
    }

    public void Yellow()
    {
        counter++;
        if (counter < 21)
        {
            colorArray[counter] = "Yellow";
        }
        if (counter > 20)
        {
            counter = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Yellow" + " " + counter);
    }

    public void FinishButton()
    {
        Debug.Log("Finish");
        if (counter >= 1)
        {
            StartCoroutine(SimonRepeats());
        }
    }

    IEnumerator Warning()
    {
        CanvasOff();
        mainText.text = "Counter is full. Clic on Finish";
        yield return new WaitForSeconds(2f);
        CanvasOn();
    }

    IEnumerator SimonRepeats()
    {
        CanvasOff();
        mainText.text =
            "Simon is going to" +
            "\n repeat the colors you pressed.";
        yield return new WaitForSeconds(2f);
        while (repeat <= counter)
        {
            mainText.text = "Color number " + repeat + 
                "\n"  + colorArray[repeat];
            repeat++;
            yield return new WaitForSeconds(1f);
        }

        // RESETTING VALUES
        counter = 0;
        repeat = 1;

        mainText.text = " Thanks for playing!";
        yield return new WaitForSeconds(2f);
        mainText.text = " Loading Title Screen.";
        yield return new WaitForSeconds(0.5f);
        mainText.text = " Loading Title Screen..";
        yield return new WaitForSeconds(0.5f);
        mainText.text = " Loading Title Screen...";
        yield return new WaitForSeconds(0.5f);
        mainText.text = " Loading Title Screen.";
        yield return new WaitForSeconds(0.5f);
        mainText.text = " Loading Title Screen..";
        yield return new WaitForSeconds(0.5f);
        mainText.text = " Loading Title Screen...";
        yield return new WaitForSeconds(0.5f);
        // RESET
        CanvasOn();
        titleCanvas.SetActive(true);
        mainCanvas.SetActive(false);

    }

    public void StartGame()
    {
        titleCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }

    public void TitleScreen()
    {
        counter = 0;
        repeat = 1;
        CanvasOn();
        mainCanvas.SetActive(false);
        titleCanvas.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
