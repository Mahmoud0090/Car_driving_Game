using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] float scoreMultiplyer;

    public const string HighScoreKey = "HighScore";

    private float Score;

    // Update is called once per frame
    void Update()
    {
        Score += Time.deltaTime * scoreMultiplyer;

        scoreText.text = Mathf.FloorToInt(Score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if (Score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(Score));
        }
    }
}
