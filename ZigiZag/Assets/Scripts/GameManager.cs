using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject loseUI;
    public int score;
    public Text loseScoreText,winScoreText;
    public Text InGameScoreText;
    public GameObject winUI;
    void Start()
    {

    }
    public void LevelEnd()
    {
        loseUI.SetActive(true);
        loseScoreText.text = "Toplam Puan: " + score;
        InGameScoreText.gameObject.SetActive(false);
        SoundManager.Instance.Play("Lose");
    }
    public void AddScore(int pointValue)
    {
        score += pointValue;
        InGameScoreText.text = "Toplam Puan: " + score;
    }
    public void StartApp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }
    public void AppQuit()
    {
        Application.Quit();
    }
    public void WinLevel()
    {
        winUI.SetActive(true);
        winScoreText.text = "Toplam Puan: " + score;
        InGameScoreText.gameObject.SetActive(false);
        SoundManager.Instance.Play("Win");
    }
    public void NextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
