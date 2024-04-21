using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseWindow : MonoBehaviour {

    private static PauseWindow instance;

    private void Awake() {
        instance = this;

        transform.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        transform.GetComponent<RectTransform>().sizeDelta = Vector2.zero;

        Button resumeButton = transform.Find("resumeBtn").GetComponent<Button>();
        resumeButton.onClick.AddListener(ResumeButtonClicked);

        Button maiMenuButton = transform.Find("mainMenuBtn").GetComponent<Button>();
        maiMenuButton.onClick.AddListener(MainMenuButtonClicked);

        Hide();
    }
    private void ResumeButtonClicked() {
        GameLogic.ResumeGame();
    }

    private void MainMenuButtonClicked() {
        Loader.Load(Loader.Scene.MainMenu);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        instance.Show();
    }

    public static void HideStatic()
    {
        instance.Hide();
    }
}
