using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject pauseMenuUI; // Duraklatma panelini referans olarak ekleyin
    public GameObject pauseButton;

    void Update()
    {
        // Oyun sırasında duraklatma işlevselliği için Escape tuşu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (Time.timeScale == 1) // Eğer oyun oynanıyorsa
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Duraklatma panelini göster
        Time.timeScale = 0; // Oyunun zamanını duraklat
        pauseButton.SetActive(false);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Duraklatma panelini gizle
        Time.timeScale = 1; // Oyunun zamanını devam ettir
    }
}
