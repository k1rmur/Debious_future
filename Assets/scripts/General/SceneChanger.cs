using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string ScenesName; 
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        ScenesName = SceneName;
            if (SceneName == "BasedRoom")
            {
                MoveController.BasedRoomPos = true;
            }
    }


}
