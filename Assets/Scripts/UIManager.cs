using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// UIManager: Bertanggung jawab HANYA untuk mengelola UI
/// Menerapkan Single Responsibility Principle
public class UIManager : MonoBehaviour
{
    // ENCAPSULATION: UI elements dilindungi
    [Header("UI Panels")]
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject gameOverPanel;

    [Header("UI Text")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI scoreTextRealtime;

    // Singleton pattern untuk akses global
    public static UIManager Instance { get; private set; }

    private void Awake()
    {
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
		    //Bagian ini nanti akan dipanggil saat Game Manager sudah dibuat
        //ShowStartPanel();
        //HideGameOverPanel();
    }

    public void ShowStartPanel()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(true);
        }
    }

    public void HideStartPanel()
    {
        if (startPanel != null)
        {
            startPanel.SetActive(false);
        }
    }

    public void ShowGameOverPanel(int finalScore)
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        if (scoreText != null)
        {
            scoreText.text = finalScore.ToString();
        }
    }

    public void HideGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    /// Update tampilan skor real-time
    public void UpdateScoreDisplay(int currentScore)
    {
        if (scoreTextRealtime != null)
        {
            scoreTextRealtime.text = currentScore.ToString();
        }
    }
}