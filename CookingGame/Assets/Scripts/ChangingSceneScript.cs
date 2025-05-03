using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScene : MonoBehaviour
{
    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }
}
