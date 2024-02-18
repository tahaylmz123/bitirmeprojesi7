using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UIElements;

public class bitis : MonoBehaviour
{
    
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Text zaman, can, durum;
    public UnityEngine.UI.Text HATIRLA,Gorev;

    public UnityEngine.UI.Image Image;
    private bool isTimeStopped = false;
    private Rigidbody rb;
  

    float zamanSayaci = 300;
    int canSayaci = 100;
    bool oyunDevam = true;
    bool oyunTamam = false;
    void Start()
    {
        can.text = canSayaci + "";
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = "SÜRE: "+(int)zamanSayaci + "";
        }
        else if (!oyunTamam)
        {
            durum.text = "Oyunu tamamlayamadýnýz";
            btn.gameObject.SetActive(true);
        }

        if (zamanSayaci <= 0)
        {
            oyunDevam = false;

        }
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 1f;
            isTimeStopped = false;
            HATIRLA.gameObject.SetActive(false);
            Gorev.gameObject.SetActive(true);

        }

    }
    private void FixedUpdate()
    {
        if (oyunDevam && !oyunTamam)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(dikey, 0, -yatay);
            
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }


    }

    private void OnCollisionEnter(Collision temasEdilen)
    {
        string objIsmi = temasEdilen.gameObject.name;
        print(temasEdilen.gameObject.name);
        if (!isTimeStopped && temasEdilen.gameObject.CompareTag("Finish"))
        {
            StopTime();

        }
       
        if (objIsmi.Equals("bitis"))
        {
            oyunTamam = true;
            durum.text = "Oyun Tamamlandý. Tebrikler.";
            btn.gameObject.SetActive(true);
            Image.gameObject.SetActive(true);

           
            


        }
        else if (!objIsmi.Equals("Ground") && !objIsmi.Equals("Terrain") && !objIsmi.Equals("Baslangic") && !objIsmi.Equals("bitis"))
        {
            canSayaci -= 1;
            can.text = canSayaci + "";
            if (canSayaci == 0)
            {
                oyunDevam = false;
            }
           
        }

       



        void StopTime()
    {
        Time.timeScale = 0f;
        isTimeStopped = true;
        Debug.Log("Time is stopped!");
            
        }
       
    }


}

   




