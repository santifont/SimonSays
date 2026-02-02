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
    int contador = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttons  = GameObject.FindGameObjectsWithTag("Button");
        mainText = GameObject.Find("MainText").GetComponent<TextMeshProUGUI>();
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
        colorArray[contador] = "Red";
        contador++;
        if (contador > 20)
        {
            contador = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Red" + " " + contador);
    }

    public void Green()
    {
        colorArray[contador] = "Green";
        contador++;
        if (contador > 20)
        {
            contador = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Green" + " " + contador);
    }

    public void Blue()
    {
        colorArray[contador] = "Blue";
        contador++;
        if (contador > 20)
        {
            contador = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Blue" + " " + contador);
    }

    public void Yellow()
    {
        colorArray[contador] = "Yellow";
        contador++;
        if (contador > 20)
        {
            contador = 20;
            StartCoroutine(Warning());
        }
        Debug.Log("Yellow" + " " + contador);
    }

    public void FinishButton()
    {
        Debug.Log("Finish");
    }

    IEnumerator Warning()
    {
        CanvasOff();
        mainText.text = "Counter is full. Clic on Finish";
        yield return new WaitForSeconds(2f);
        CanvasOn();
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
