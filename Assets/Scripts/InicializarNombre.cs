using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InicializarNombre : MonoBehaviour
{
    public TMP_Text username;
    // Start is called before the first frame update
    void Start()
    {
        username.text = PlayerPrefs.GetString("username");
    }

}
