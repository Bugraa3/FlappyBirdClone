using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton; // Buton referansı

    void Start()
    {
        // Play butonuna işlev ekleyin
        playButton.onClick.AddListener(StartGame);
    }

    public void StartGame() // Fonksiyonun public olduğundan emin olun
    {
        // Oyun sahnesini yükle
        SceneManager.LoadScene("GameScene"); // Oyun sahnenizin adıyla değiştirin
    }
}
