using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text OutputText;
    public InputField textfield;
    public string nama;
    private void Awake() // fungsi singleton agar GameObject gamemanager ga hancur ketika ganti scene.
    {
        LoadInformation();
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
        if (nama != "")
        {
            OutputText.text = "Welcome Back, " + nama + "!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenMainScene()
    {
        if(textfield.text != "")
        {
            nama = textfield.text;
            SavingInformation();
            SceneManager.LoadScene(1);

        }
    }

    public void Exit()
    {
        SavingInformation();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif  
    }

    [System.Serializable]
    public class SaveData
    {
        public string textName;
    }

    public void SavingInformation()
    {
        SaveData data = new SaveData();
        data.textName = nama;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadInformation()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            nama = data.textName;
        }
    }

}
