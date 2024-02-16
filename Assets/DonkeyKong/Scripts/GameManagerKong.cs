using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerKong : MonoBehaviour
{
    private int level;
    private int lives;
    private int score;

    private void Start() {
        DontDestroyOnLoad(gameObject);
    }

    private void LoadLevel(int index){
        level = index;
        Camera camera = Camera.main;
        if (camera != null){
            camera.cullingMask = 0;
        }
        Invoke(nameof(LoadScene),1f);
    }

    private void LoadScene() {
        SceneManager.LoadScene(level);
    }

    public void LevelComplete(){    
        LoadLevel(4);
    }

    public void LevelFailed(){
        LoadLevel(0);
}
}
