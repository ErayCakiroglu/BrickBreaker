using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    [SerializeField] float hiz;


    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(hiz * Time.deltaTime, 0f, 0f));
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-hiz * Time.deltaTime, 0f, 0f));
        }
          
    }
}
