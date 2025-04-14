using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Transition : MonoBehaviour
{
    public string NameScene;
    public void Transition()
    {
        SceneManager.LoadScene(NameScene);
    }
}
