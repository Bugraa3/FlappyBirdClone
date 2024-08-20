using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject pauseMenuUI; // Duraklatma menüsünün referansı
    public Button pauseButton; // Duraklatma butonunun referansı
    public Button restartButton; // Yeniden başlatma butonunun referansı
    public Button resumeButton; // Devam etme butonunun referansı

    void Start()
    {
        // Oyun başladığında duraklatma menüsünü gizle ve butonu göster
        pauseMenuUI.SetActive(false);
        pauseButton.gameObject.SetActive(true);

        // Butonlara işlev ekleyin
        restartButton.onClick.AddListener(Restart);
        resumeButton.onClick.AddListener(Resume);
    }

    void Update()
    {
        // Escape tuşuna basıldığında duraklatma işlemi
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
        pauseMenuUI.SetActive(true); // Duraklatma menüsünü göster
        pauseButton.gameObject.SetActive(false); // Duraklatma butonunu gizle
        Time.timeScale = 0; // Oyunun zamanını duraklat
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Duraklatma menüsünü gizle
        pauseButton.gameObject.SetActive(true); // Duraklatma butonunu göster
        Time.timeScale = 1; // Oyunun zamanını devam ettir
    }

    public void Restart()
    {
        Time.timeScale = 1; // Zamanı devam ettir
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Aynı sahneyi yeniden yükle
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1; // Zamanı devam ettir
        SceneManager.LoadScene("MainMenu"); // Ana menü sahnesine geç
    }
}
