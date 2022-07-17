using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScoreText(int score)
    {
        scoreText.text = "Score : " + score;
    }

    public void SetWinText()
    {
        scoreText.text = "You Win !";
    }
}
