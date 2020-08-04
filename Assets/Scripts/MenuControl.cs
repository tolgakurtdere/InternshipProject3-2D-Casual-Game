using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public GameObject infoPanel;
    public Button infoButton, playButton, exitButton;
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Info()
    {
        infoPanel.SetActive(true);
        infoButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
    }

    public void GotIt()
    {
        LeanTween.scale(infoPanel.gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(ClosePanel);
    }
    private void ClosePanel()
    {
        infoPanel.gameObject.SetActive(false);
        infoPanel.transform.localScale = Vector3.one;
        infoButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
    }
}
