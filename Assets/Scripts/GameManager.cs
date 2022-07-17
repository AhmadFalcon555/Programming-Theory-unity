using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake() // fungsi singleton agar GameObject gamemanager ga hancur ketika ganti scene.
    {
        if(Instance != null) //artinya uda ada atau udah dibikin
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //save something here
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif  
    }

}
