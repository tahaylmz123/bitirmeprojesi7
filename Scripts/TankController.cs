using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public Camera Kamera;
    public Transform TankKamerasi;
    public GameObject TankPaleti;
    public GameObject TankKulesi;
    public GameObject TankAnaSilahi;
    public GameObject TankTopCikis;
    public GameObject TankTopu;
    public float TankHizi;
    public float TankDonme;
    public float MermiDolmaSuresi;
    public float YeniMermiSuresi;
    public float SilahinMinXSiniri;
    public float SilahinMaxXSiniri;
    public float FareHassasiyeti;
    private float FareninXEkseni;
    private float FareninYEkseni;
    public GameObject TankTopuCikisi;
    
    // Start is called before the first frame update
    void Start()
    {
        Kamera = Camera.main;
        Kamera.transform.SetParent(TankKamerasi);
        Kamera.transform.localPosition = new Vector3(TankKamerasi.transform.position.x, TankKamerasi.transform.position.y, -5.4f);
        Kamera.transform.localRotation = Quaternion.Euler(TankKamerasi.transform.rotation.x, TankKamerasi.transform.rotation.y, TankKamerasi.transform.rotation.z);
        TankHizi = 1f;
        MermiDolmaSuresi = 5f;
        SilahinMinXSiniri = -5f;
        SilahinMaxXSiniri = 20f;
        FareHassasiyeti = 5f;
        FareninXEkseni = 0f;
        FareninYEkseni = 0f;
     
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TankHareketi();
      
    }
    void TankHareketi()
    {
        transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * TankHizi * Time.deltaTime);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * TankDonme, 0f);
    }
    void TankNisanAlma()
    {
        FareninYEkseni += Input.GetAxis("Mouse X") * FareHassasiyeti * Time.deltaTime;
        FareninXEkseni += Input.GetAxis("Mouse Y") * FareHassasiyeti * Time.deltaTime;
        FareninXEkseni = Mathf.Clamp(FareninXEkseni, SilahinMinXSiniri, SilahinMaxXSiniri);
        TankAnaSilahi.transform.localRotation = Quaternion.Euler(-FareninXEkseni, 0, 0);
        TankKulesi.transform.localRotation = Quaternion.Euler(0, FareninYEkseni, 0);
        YeniMermiSuresi += Time.deltaTime;
       
    }
   
    }

