using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text Player1ScoreText;
    [SerializeField] private Text Player2ScoreText;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void AddScoreForPlayer1()
    {
        Player1Score++;
    }
    public void AddScoreForPlayer2()
    {
        Player2Score++;
    }

    void Update()
    {
        Player1ScoreText.text = Player1Score.ToString();
        Player2ScoreText.text = Player2Score.ToString();
    }

}
