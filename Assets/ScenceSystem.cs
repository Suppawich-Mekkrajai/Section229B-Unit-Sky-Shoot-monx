using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceSystem : MonoBehaviour
{
    [SerializeField] private string newSceneName;


 public void LoadScene()
 {
     SceneManager.LoadScene(newSceneName);
 }
 public void ExitGame()
 {
     Application.Quit();
 }
    
}
