using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string game = "game"; 

    // Fonction appelée lorsque le bouton "Jouer" est cliqué
    public void PlayGame()
    {
        if (Application.CanStreamedLevelBeLoaded(game))
        {
            SceneManager.LoadScene(game);
        }
        else
        {
            Debug.LogError($"La scène '{game}' n'existe pas ou n'est pas incluse dans les Build Settings.");
        }
    }

    // Fonction appelée lorsque le bouton "Quitter" est cliqué
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Arrête le jeu dans l'éditeur Unity
#else
        Application.Quit(); // Quitte le jeu une fois buildé
#endif
    }
}
