using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string game = "game"; 

    // Fonction appel�e lorsque le bouton "Jouer" est cliqu�
    public void PlayGame()
    {
        if (Application.CanStreamedLevelBeLoaded(game))
        {
            SceneManager.LoadScene(game);
        }
        else
        {
            Debug.LogError($"La sc�ne '{game}' n'existe pas ou n'est pas incluse dans les Build Settings.");
        }
    }

    // Fonction appel�e lorsque le bouton "Quitter" est cliqu�
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Arr�te le jeu dans l'�diteur Unity
#else
        Application.Quit(); // Quitte le jeu une fois build�
#endif
    }
}
