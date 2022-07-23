using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TopEtkilesimi : MonoBehaviour
{
    [SerializeField] Rigidbody2D top;
    [SerializeField] float yatayHiz, dikeyHiz;
    [SerializeField] GameObject topObjesi, oyuncuObjesi, puanObjesi;
    [SerializeField] TextMeshProUGUI kaybettikYazisi;

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.transform.tag == "UstDuvar")
        {
            top.velocity = new Vector2(top.velocity.x, -dikeyHiz);
        }

        if(temas.gameObject.transform.tag == "SolDuvar")
        {
            top.velocity = new Vector2(yatayHiz, top.velocity.y);
        }

        if(temas.gameObject.transform.tag == "SagDuvar")
        {
            top.velocity = new Vector2(-yatayHiz, top.velocity.y);
        }

        if(temas.gameObject.transform.tag == "Player")
        {
            top.velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(7f, 10f));
        }

        if(temas.gameObject.transform.tag == "AltDuvar")
        {
            kaybettikYazisi.text = "Maalesef ki oyunu kazanamadınız.\n Puanınız : " + Kazandik.puan + "\nKırılan blok sayısı : " + Kazandik.kirilanBlokSayisi + "\n\nTekrar oynamak için bir tuşa basınız.";
            Time.timeScale = 0;
            Destroy(topObjesi.gameObject);
            Destroy(oyuncuObjesi.gameObject);
            Destroy(puanObjesi.gameObject);
        }
    }
}
