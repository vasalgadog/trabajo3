using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowJammo : MonoBehaviour
{
    public GameObject Jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + new Vector3(0,559.43f,40.9f);
    }
}
