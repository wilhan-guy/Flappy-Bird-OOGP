using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Singleton (biar mudah diakses dari mana saja)
    public static ScoreManager Instance;

    // ENCAPSULATION: skor disimpan private
    private int _currentScore = 0;

    private void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // 2. Initialize UI dengan skor awal (0)
        UpdateUI();
    }

    // Method untuk menambah skor
    public void AddScore(int value)
    {
        _currentScore += value;

        // 3. Update UI setiap skor berubah
        UpdateUI();
    }

    // 1. Function Update UI
    private void UpdateUI()
    {
        if (UIManager.Instance != null)
        {
            UIManager.Instance.UpdateScoreDisplay(_currentScore);
        }
    }

    // (Optional) Getter jika diperlukan
    public int GetScore()
    {
        return _currentScore;
    }
}