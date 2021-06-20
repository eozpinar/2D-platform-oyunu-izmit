using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finish1 : MonoBehaviour
{
    public GameObject panel;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Player")
        {
            panel.SetActive(true);
        }
    }
}
