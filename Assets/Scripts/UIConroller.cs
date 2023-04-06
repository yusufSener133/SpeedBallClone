using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIConroller : MonoBehaviour
{
    [SerializeField] GameObject _winPanel, _losePanel;
    [SerializeField] TextMeshProUGUI _scoreText;

    public bool Win
    {
        get { return Win; }
        set
        {
            if (value == true)
            {
                Time.timeScale = 0;
                _winPanel.SetActive(true);
            }
        }
    }
    public bool Lose
    {
        get { return Lose; }
        set
        {
            if (value == true)
            {
                Time.timeScale = 0;
                _losePanel.SetActive(true);
            }
        }
    }
    int _score;
    public int Score { get; set; }

    private void Start()
    {
        Score = 0;
        Time.timeScale = 1;
    }
    void Update()
    {
        _scoreText.text = "Score : " + Score.ToString();
    }
    public void WinButton()
    {
        SceneManager.LoadScene(0);
    }
    public void LoseButton()
    {
        SceneManager.LoadScene(0);
    }
}
