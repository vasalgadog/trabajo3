using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public TMP_Text tiempo;
    public bool seguir;
    public float restante;
    public Canvas canvas2;
    public AudioSource _as;
    public AudioClip audioClip1;

	private void Awake()
	{
        seguir = true;
        restante = 30;
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seguir)
        {
			restante -= Time.deltaTime;
			if (restante <= 0 && restante > -1)
			{
                _as.PlayOneShot(audioClip1);
				seguir = false;
                canvas2.enabled= true;
			}

			tiempo.text = Mathf.FloorToInt(restante+1).ToString();
		}
    }

    public void gano()
    {
        seguir = false;
    }
}
