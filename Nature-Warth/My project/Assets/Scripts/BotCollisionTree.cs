using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotCollisionTree : MonoBehaviour
{
    public GameObject gameOverPanel; // Referência ao painel de Game Over no Canvas
    public Button resetButton; // Referência ao botão de reset no Canvas
    public GameObject gamePanel; // Referência ao Reset do canto superior direito
    public int maxHealth = 100;
    public int currentHealth = 0;
    public HealthBar healthBar;

    private Coroutine healthDecrementCoroutine;

    private void Start()
    {
        gameOverPanel.SetActive(false); // Desativa o painel de Game Over no início do jogo
        // Atualizar a vida
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree")
        {
            if (healthDecrementCoroutine == null)
            {
                healthDecrementCoroutine = StartCoroutine(DecrementHealth());

            }
        }
    }

    IEnumerator DecrementHealth()
    {
        while (currentHealth > 5)
        {
            yield return new WaitForSeconds(2f);

            currentHealth -= 20;
            healthBar.SetHealth(currentHealth);

        }

        Time.timeScale = 0f; // Pausa o jogo definindo a escala de tempo para zero
        gameOverPanel.SetActive(true); // Ativa o painel de Game Over
        resetButton.onClick.AddListener(ResetGame); // Adiciona um listener para o botão de reset
        gamePanel.SetActive(false); // Remove o Reset do canto superior direito
    }



    private void ResetGame()
    {
        // Coloque aqui a lógica para reiniciar o jogo, como recarregar a cena ou redefinir variáveis
        Time.timeScale = 1f; // Reseta a escala de tempo para retomar o jogo normalmente
    }
}
