using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Define o nome da cena principal do jogo
    public string mainSceneName = "SampleScene";

    private Button resetButton;

    private void Start()
    {
        // Obtém a referência para o componente Button do objeto
        resetButton = GetComponent<Button>();

        // Adiciona um listener para o evento de clique no botão
        resetButton.onClick.AddListener(ResetExecutable);
    }

    // Método chamado quando o botão for clicado
    private void ResetExecutable()
    {
        // Carrega novamente a cena principal
        SceneManager.LoadScene(mainSceneName);
    }
}