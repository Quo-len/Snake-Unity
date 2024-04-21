using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuWindow : MonoBehaviour {
    private void Awake() {
        Button playButton = transform.Find("mainSub/playBtn").GetComponent<Button>();
        playButton.onClick.AddListener(PlayButtonClicked);

        Button quitButton = transform.Find("mainSub/quitBtn").GetComponent<Button>();
        quitButton.onClick.AddListener(QuitButtonClicked);
    }

    private void PlayButtonClicked() {
        Loader.Load(Loader.Scene.Game);
        Time.timeScale = 1f;
    }

    private void QuitButtonClicked() {
        Application.Quit();
    }
}
