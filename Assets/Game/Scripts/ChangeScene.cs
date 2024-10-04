using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName;

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
