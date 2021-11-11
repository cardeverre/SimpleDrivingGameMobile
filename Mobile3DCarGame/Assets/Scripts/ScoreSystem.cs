using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    private float score; 
    public const string HighScoreKey = "HighScore";
    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier; 
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy() {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
