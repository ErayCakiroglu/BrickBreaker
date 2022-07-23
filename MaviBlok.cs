using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaviBlok : MonoBehaviour
{
    [SerializeField] int blokSagligi;
    [SerializeField] AudioSource kirilmaSesi;

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Top")
        {
            kirilmaSesi.Play();
            blokSagligi--;
        }

        if(blokSagligi == 0)
        {
            Kazandik.kirilanBlokSayisi++;
            Kazandik.puan += 10;
            Destroy(this.gameObject);
        }
    }
}
