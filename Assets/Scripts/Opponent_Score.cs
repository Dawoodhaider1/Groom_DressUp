using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opponent_Score : MonoBehaviour
{
    public Text score;
    private int x;

    public static int Score_earned_Opponent = 0;

    void Start()
    {
        x = 0;
        ScoreText();
        x = (x + Score_earned_Opponent);
        Score_earned_Opponent = x;
    }

    public void ScoreText()
    {
        x = Random.Range(5, 10);
        score.text = x.ToString();
    }
}
