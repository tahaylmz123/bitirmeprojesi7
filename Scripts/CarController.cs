using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{ 
    // yatayda girilen verileri okuma
    private float horizontalInput;
    // dikeyde girilen verileri okuma
    private float verticalInput;
    // fren i�in veri tan�mlama 
    private bool isFren;
    // frene bas�ld���nda fren kuvveti buradan al�n�r
    private float currentFrenForce;
    // araban�n sa�a sola d�n�� a��s�n� ayarlama
    private float currentDonusAcisi;
    // araban�n maximum sa� ve sola d�n�� a��s�n� ayarlama
    [SerializeField] private float maxDonusAcisi;
    // araban�n kalk�� h�z�n� ayarlama
    [SerializeField] private float motorTorkKuvvet;
    // fren kuvveti
    [SerializeField] private float frenKuvvet;
    public float rotate;

    // tekerlerin colliderlerini inspectorda g�rmek i�in kodlar
    [SerializeField] private WheelCollider onsagtekerCol;
    [SerializeField] private WheelCollider onsoltekerCol;
    [SerializeField] private WheelCollider arkasagtekerCol;
    [SerializeField] private WheelCollider arkasoltekerCol;
    [SerializeField] private WheelCollider tekerCol1;
    [SerializeField] private WheelCollider tekerCol2;
    [SerializeField] private WheelCollider tekerCol3;
    [SerializeField] private WheelCollider tekerCol4;
    [SerializeField] private WheelCollider tekerCol5;
    [SerializeField] private WheelCollider tekerCol6;
    [SerializeField] private WheelCollider tekerCol7;
    [SerializeField] private WheelCollider tekerCol8;
    [SerializeField] private WheelCollider tekerCol9;
    [SerializeField] private WheelCollider tekerCol10;
   

    // tekerlerin ilerlemesi i�in transformlar� g�rmeye yar�yor 
    [SerializeField] private Transform onsoltekertransform;
    [SerializeField] private Transform onsagtekertransform;
    [SerializeField] private Transform arkasoltekertransform;
    [SerializeField] private Transform arkasagtekertransform;
    [SerializeField] private Transform tekertransform1;
    [SerializeField] private Transform tekertransform2;
    [SerializeField] private Transform tekertransform3;
    [SerializeField] private Transform tekertransform4;
    [SerializeField] private Transform tekertransform5;
    [SerializeField] private Transform tekertransform6;
    [SerializeField] private Transform tekertransform7;
    [SerializeField] private Transform tekertransform8;
    [SerializeField] private Transform tekertransform9;
    [SerializeField] private Transform tekertransform10;
   

    private void FixedUpdate()
    {   // yaz�lan fonksiyonlar� belirtme ve etkileme
        getUserUpdate();
        MoveTheCar();
        rotateCar();
    }
    // araban�n  �n tekerlerini sa�a ve sola d�nmek i�in yaz�lm�� fonksiyon
    private void rotateCar()
    {   // don�� a��s�n� klavyeden girilen de�erle �arp�p currentte aktar�r
        currentDonusAcisi = maxDonusAcisi * horizontalInput;
        // tekerlerin a��s�n� ayarlar
        onsagtekerCol.steerAngle = currentDonusAcisi;
        onsoltekerCol.steerAngle = currentDonusAcisi;


        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -rotate * Time.deltaTime);
        }
        
    }
    // arac�n ileri ve geri ditmesi i�in tekerlere kuvvet uygular
    private void MoveTheCar()
    {
        // teker colliderlerine yatayda girilen veri ile motor kuvveti �arp�l�r 
        onsagtekerCol.motorTorque = verticalInput * motorTorkKuvvet;
        onsoltekerCol.motorTorque = verticalInput * motorTorkKuvvet;
        arkasagtekerCol.motorTorque = verticalInput * motorTorkKuvvet;
        arkasoltekerCol.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol1.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol2.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol3.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol4.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol5.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol6.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol7.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol8.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol9.motorTorque = verticalInput * motorTorkKuvvet;
        tekerCol10.motorTorque = verticalInput * motorTorkKuvvet;
        
        // frene bas�ld�m� onu kontrol eder
        currentFrenForce = isFren ? frenKuvvet : 0f;
        // frene bas�ld� ise frene tork uygulayarak durdurur
        if (isFren)
        {
            onsagtekerCol.brakeTorque = currentFrenForce;
            onsoltekerCol.brakeTorque = currentFrenForce;
            arkasagtekerCol.brakeTorque = currentFrenForce;
            arkasoltekerCol.brakeTorque = currentFrenForce;
            tekerCol1.brakeTorque = currentFrenForce;
            tekerCol2.brakeTorque = currentFrenForce;
            tekerCol3.brakeTorque = currentFrenForce;
            tekerCol4.brakeTorque = currentFrenForce;
            tekerCol5.brakeTorque = currentFrenForce;
            tekerCol6.brakeTorque = currentFrenForce;
            tekerCol7.brakeTorque = currentFrenForce;
            tekerCol8.brakeTorque = currentFrenForce;
            tekerCol9.brakeTorque = currentFrenForce;
            tekerCol10.brakeTorque = currentFrenForce;
        }
        // frene bas�lmad�ysa kuvveti 0 yapar
        else
        {
            onsagtekerCol.brakeTorque = 0f;
            onsoltekerCol.brakeTorque = 0f;
            arkasagtekerCol.brakeTorque = 0f;
            arkasoltekerCol.brakeTorque = 0f;
        }
    }
    // klavye girdilerini kontrol eder
    private void getUserUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isFren = Input.GetKey(KeyCode.Space);
    }
}
