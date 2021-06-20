using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pismaniye : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
