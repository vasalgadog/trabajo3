using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciaJuego : MonoBehaviour
{
    public void iniciarJuego()
    {
		SceneManager.LoadScene("EscenaLaberinto");
	}
}
