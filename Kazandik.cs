using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Kazandik : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI kazandikYazisi, puanYazisi;
    public static int puan, kirilanBlokSayisi;
    [SerializeField] Transform bloklar;
    int blokSayisi;
    [SerializeField] GameObject yaziObjesi, topObjesi, oyuncuObjesi;

    void Start()
    {
        puan= 0;
        kirilanBlokSayisi = 0;
    }

    void Update()
    {

        if(Time.timeScale == 0)
        {
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }

        puanYazisi.text = "Puan : " + puan;
        blokSayisi = bloklar.childCount;

        if(blokSayisi == 0)
        {
            kazandikYazisi.text = "Tebrikler oyunu kazandınız.\n Puanınız : " + puan + "\nKırılan blok sayısı : " + kirilanBlokSayisi + "\n\nTekrar oynamak için bir tuşa basınız.";
            Time.timeScale = 0;
            Destroy(yaziObjesi.gameObject);
            Destroy(topObjesi.gameObject);
            Destroy(oyuncuObjesi.gameObject);

            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
