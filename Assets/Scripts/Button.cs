using UnityEngine;

public class Button : MonoBehaviour
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

    public void RedButton()
    {
        Debug.Log("RED");
    }

    public void GreenButton()
    {
        Debug.Log("GREEN");
    }

    public void BlueButton()
    {
        Debug.Log("BLUE");
    }

    public void YellowButton()
    {
        Debug.Log("YELLOW");
    }
}
