using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesilBlok : MonoBehaviour
{
    [SerializeField] int blokSagligi;
    MeshRenderer ressam;
    [SerializeField] Material yesilKirik;
    [SerializeField] AudioSource kirilmaSesi;
    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }

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
            Kazandik.puan += 20;
            Destroy(this.gameObject);
        }

        if(blokSagligi == 1)
        {
            ressam.material = yesilKirik;
        }
    }
}
