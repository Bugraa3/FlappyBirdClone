using UnityEngine;
using UnityEngine.SceneManagement; // Bu namespace oyunun sahneleriyle ilgili işlemleri yapar

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // Game Over paneli referansı

    private void Start()
    {
        // Oyuna başlarken paneli gizle
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true); // Game Over panelini göster
        Time.timeScale = 0; // Oyunun zamanını durdur
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // Oyunun zamanını yeniden başlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Mevcut sahneyi yeniden yükle
    }
}
