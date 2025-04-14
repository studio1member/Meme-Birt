using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManagerScene : MonoBehaviour
{
    public static LobbyManagerScene Instance;
    public string Map;
    
    private void Awake()
    {
        Instance = this;
        _AwakeMap();
    }
    private void _AwakeMap()
    {
        if (PlayerPrefs.GetString("Chooose Map") == "") PlayerPrefs.SetString("Chooose Map", "Map 1");
    }
    public void _ApplyMap_Button()
    {
        PlayerPrefs.SetString("Chooose Map", Map);
    }
    public void _PlayGame_Button()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("Chooose Map"));
    }
}
