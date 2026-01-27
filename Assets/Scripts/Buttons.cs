using UnityEngine;

public class Buttons : MonoBehaviour
{
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Red()
    {
        Debug.Log("Red");
    }

    public void Green()
    {
        Debug.Log("Green");
    }

    public void Blue()
    {
        Debug.Log("Blue");
    }

    public void Yellow()
    {
        Debug.Log("Yellow");
    }
}
