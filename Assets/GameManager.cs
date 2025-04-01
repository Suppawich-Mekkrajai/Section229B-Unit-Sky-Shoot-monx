using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Guncon gunController;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI resultText;
    public int enemiesToDestroy = 7;
    public int score = 0;
    public float timeLeft = 30f;

    public GameObject resultPanel;

    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeLeft);
        }
        else
        {
            EndGame();
        }
    }
    void EndGame()
    {
        timerText.text = "Time: 0";
        resultText.text = "Game Over!";
        resultPanel.SetActive(true);
        gunController.onPlaying = false;
    }

    public void AddScore(int amount)
    {
        score += amount;
        enemiesToDestroy--;
        scoreText.text = "Score: " + score;

        if (enemiesToDestroy <= 0)
        {
            resultText.text = "You Win!";
            resultPanel.SetActive(true);
            gunController.onPlaying = false;
        }
    }
    public void StartButton()
    {
        gunController.onPlaying = true;
    }
    public void OptionButton()
    {
        
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BulletHitTarget()
    {
        AddScore(1);
    }
} 
  

