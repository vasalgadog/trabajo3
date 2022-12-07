using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class llegaMeta : MonoBehaviour
{
    public AudioSource _as;
	public AudioClip _asClip1;
	public Canvas canvasGana;
	public TimerController timerControler;


	private void OnTriggerEnter(Collider other)
	{
		_as.PlayOneShot(_asClip1);
		timerControler.gano();
		canvasGana.enabled = true;
	}
}
