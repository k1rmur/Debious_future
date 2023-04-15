using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] scenes = new string[2];
    private bool flagForArray2 = false;
    private string OldScenes;
    private bool flagForArray1 = true;
    private string wasScene;
    private static string SceneNow;
    private static GameManager _instance;
    private string OldScene;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<GameManager>();
            return Instance;
        }
    }

    private void Awake()
    {
        GameManager[] managers = FindObjectsOfType<GameManager>();

        for (int i = 0; i < managers.Length; i++)
            if (managers[i].GetInstanceID() != this.GetInstanceID())
                Destroy(this.gameObject);

        Object.DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode loadMode)
    {

    }



    private void Update()
    {
        SceneNow = SceneManager.GetActiveScene().name;
        if (string.IsNullOrEmpty(scenes[0]) && flagForArray1 == false)
        {
            scenes[0] = SceneNow;
            OldScene = scenes[0];
        }
        else
        {
            if (scenes[1] != SceneNow)
            {
                OldScene = scenes[1];
                scenes[0] = OldScene;
                scenes[1] = SceneNow;
                flagForArray1 = true;
            }
        }
    }
}


