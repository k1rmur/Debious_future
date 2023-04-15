using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    [SerializeField] private string[] Scenes = new string[2];
    private bool flagForArray = false;
    private string SceneNow;
    private void Update()
    {
        SceneNow = SceneManager.GetActiveScene().name;
        if (string.IsNullOrEmpty(Scenes[0]) || !string.IsNullOrEmpty(Scenes[1]) && flagForArray == true)
        {
            Scenes[1] = SceneNow ;
            print("1");
        }
        else
        {
           if (!string.IsNullOrEmpty(Scenes[0]) && flagForArray == false && Scenes[1] != Scenes[2])
            {
                string OldScene = Scenes[0];
                Scenes[0] = SceneNow;
                flagForArray = true;
                print("2");
            }
        }
    }


}
