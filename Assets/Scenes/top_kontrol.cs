using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class top_kontrol : MonoBehaviour
{
    public TMPro.TextMeshProUGUI skor_txt;
    public TMPro.TextMeshProUGUI can_txt;
    public TMPro.TextMeshProUGUI tugla_txt; 

    public Rigidbody top_rigi;
    Vector3 baslangic_koordinati;
    GameObject[] tuglalar;

    float hiz = 7.0f;
    int skor = 0;
    int kirilan_tugla = 0;
    int toplam_tugla;
    int toplam_can = 3;

    public AudioSource ses;
    public AudioClip[] sesler;
    

    void Start()
    {
        
        tuglalar = GameObject.FindGameObjectsWithTag("tugla");
        toplam_tugla = tuglalar.Length;

        tugla_txt.text = kirilan_tugla + "/" + toplam_tugla;
        baslangic_koordinati = transform.position;

        ses = GetComponent<AudioSource>();
        baslangic_vurusu();     
    }
    void sahne_change()
    {
        SceneManager.LoadScene(1);
    }
    void baslangic_vurusu()
    {
        top_rigi.velocity = Vector3.zero; //gücü sıfırlama
        transform.position = baslangic_koordinati;
        top_rigi.velocity = new Vector3(hiz, 0, hiz); //güc uygulama
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tugla")
        {
            Destroy(collision.gameObject);
            skor += 100;
            kirilan_tugla++;

            skor_txt.text = "SKOR:" + skor;
            tugla_txt.text = kirilan_tugla + "/" + toplam_tugla;
            ses.PlayOneShot(sesler[0], 1);

            if (kirilan_tugla == toplam_tugla)
            {
                sahne_change();
            }

        }

        if(collision.gameObject.name == "sag_duvar")
        {
            top_rigi.velocity = new Vector3(-hiz,0,top_rigi.velocity.z);
        }

        if (collision.gameObject.name == "sol_duvar")
        {
            top_rigi.velocity = new Vector3(hiz, 0, top_rigi.velocity.z);
        }

        if (collision.gameObject.name == "cikis")
        {
            toplam_can--;
            can_txt.text = toplam_can.ToString();

            if (toplam_can == 0)
            {
                SceneManager.LoadScene(3);
            }

            baslangic_vurusu();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
