using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class ScoreManager : Singleton<ScoreManager>
{
    [SerializeField] protected TMP_Text textScore;
    [SerializeField] protected TMP_Text Timer;
    [SerializeField] protected TMP_Text hightScorePopUp;
    int hightScore;
    int scorE;
    float CurrentTime;
    private void OnEnable()
    {
        ObserverManager<int>.AddObserver("Score", OnUpdateScore);
    }
    private void OnDestroy()
    {
        ObserverManager<int>.RemoveObserver("Score", OnUpdateScore);
    }
    private void Update()
    {
        this.CurrentTime += Time.deltaTime;

        this.Timer.text = "Time: "  + CurrentTime.ToString();

        // =)) e xin loi a khanh, do e luoi
        this.OnUpdateHightScorePopUp();
    }

    public void OnUpdateScore(int score)
    {
        scorE += score;
        PlayerPrefs.SetInt("Score", score);
        this.textScore.text = "Score: " + scorE.ToString();

        if (scorE > hightScore)
        {
            hightScore = scorE;
            PlayerPrefs.SetInt("HightScore", hightScore);
        }
    }
    public void OnUpdateHightScorePopUp()
    {
        this.hightScorePopUp.text = "Best: " + PlayerPrefs.GetInt("HightScore", hightScore);
    }
}
