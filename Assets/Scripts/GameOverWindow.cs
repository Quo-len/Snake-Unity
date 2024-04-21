using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour {
    private static GameOverWindow instance;

    public TMP_InputField nameInputField;

    private void Start() {
        instance = this;

        Button retryButton = transform.Find("retryBtn").GetComponent<Button>();

        retryButton.onClick.AddListener(RetryButtonClicked);

        Hide();
    }

    private void RetryButtonClicked() {
        Loader.Load(Loader.Scene.Game);
    }

    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

    public static void ShowStatic() {
        instance.Show();
    }

    public void SubmitScore()
    {
        nameInputField.image.color = Color.red;
        string playerNameToLeaderboard;
        if (nameInputField.text == "")
        {
            playerNameToLeaderboard = "---";
        }
        else
        {
            playerNameToLeaderboard = nameInputField.text;
        }
        int scoreToLeaderboard = Mathf.RoundToInt(GameLogic.GetScore());
        HighScoreTable.AddHighscoreEntry(scoreToLeaderboard, playerNameToLeaderboard);
    }

}
