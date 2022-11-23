using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Score : MonoBehaviour
{
    public Text Display_Score_Player;
    public Text Display_Score_Opponent;
    public static int F_Score_player = 0;
    public static int F_Score_Opponent = 0;

    void Start()
    {
        F_Score_player = (Score.Score_earned / 3);
        Display_Score_Player.text = F_Score_player.ToString();

        F_Score_Opponent = (Opponent_Score.Score_earned_Opponent / 3);
        Display_Score_Opponent.text = F_Score_Opponent.ToString();

        StartCoroutine(reset());
    }

    IEnumerator reset()
    {
        yield return new WaitForSeconds(4);
        reset_Score();
    }
    
    public void reset_Score()
    {
        F_Score_player = 0;
        F_Score_Opponent = 0;
    }
}
