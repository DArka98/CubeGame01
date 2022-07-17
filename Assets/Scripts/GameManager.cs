using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false;
    public UIController uiController;
    public AdController adController;
    public bool bonusForWatchingAd = false;

    public void ScoreIncrease()
    {
        score += 1;
        uiController.SetScoreText(score);

        if(score == 4)
        {
            gameOver = true;
            uiController.SetWinText();
            adController.ShowInterstitialAd();
        }

        if (score == 2)
        {
            adController.ShowRewardedAd();
        }
    }

    public void GiveBonus()
    {
        bonusForWatchingAd = true;
    }
}
