using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public TMP_InputField inputUsername;
    public Scene ARScene;

    public void saveData()
    {
        if (inputUsername.text.Length > 0)
        {
			PlayerPrefs.SetString("username", inputUsername.text);
            PlayerPrefs.Save();

            SceneManager.LoadScene("ARScene");
		}
        
    }

}
