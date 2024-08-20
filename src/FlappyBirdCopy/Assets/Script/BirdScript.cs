using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    public float zıplama_aralıgı;
    public Text skor_text;
    public float skor;
    public AudioSource audioSource; // Ses kaynağı referansı
    public AudioClip scorerSound; // Çalmak istediğiniz ses dosyası
    public GameOverManager gameOverManager;

    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        skor = 0;

        // Eğer ses kaynağı veya ses dosyası eksikse, hata ayıklama için log ekleyin
        if (audioSource == null)
        {
            Debug.LogError("AudioSource bileşeni eksik!");
        }
        if (scorerSound == null)
        {
            Debug.LogError("Scorer ses dosyası eksik!");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            rb2d.velocity = Vector2.up * zıplama_aralıgı;
        }

        skor_text.text = skor.ToString();
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Scorer")
        {
            skor++;

            // Ses çaldırma
            if (audioSource != null && scorerSound != null)
            {
                audioSource.PlayOneShot(scorerSound);
            }
        }
        else if (temas.gameObject.tag == "Pipe")
        {
            gameOverManager.ShowGameOverPanel();
        }
    }
}
