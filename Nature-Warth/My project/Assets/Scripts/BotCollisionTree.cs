using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotCollisionTree : MonoBehaviour
{
    public GameObject gameOverPanel; // Referência ao painel de Game Over no Canvas
    public Button resetButton; // Referência ao botão de reset no Canvas
    public GameObject gamePanel; // Referência ao Reset do canto superior direito

    private void Start()
    {
    gameOverPanel.SetActive(false); // Desativa o painel de Game Over no início do jogo
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject.tag == "Tree")
        {
            Time.timeScale = 0f; // Pausa o jogo definindo a escala de tempo para zero
            gameOverPanel.SetActive(true); // Ativa o painel de Game Over
            resetButton.onClick.AddListener(ResetGame); // Adiciona um listener para o botão de reset
            gamePanel.SetActive(false); //Remover o Reset do canto superior direito
        }
    }

    private void ResetGame()
    {
        // Coloque aqui a lógica para reiniciar o jogo, como recarregar a cena ou redefinir variáveis
        Time.timeScale = 1f; // Reseta a escala de tempo para retomar o jogo normalmente
    }
}
