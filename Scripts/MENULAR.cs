using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class MENULAR : MonoBehaviour
{
    public UnityEngine.UI. Image panel;
   public void cýkýs()
    {
        Application.Quit();
    }
   public void OYUNMENU()
    {
        SceneManager.LoadScene(1);
    }
   public void ayarlar()
    {
        panel.gameObject.SetActive(true);
    }
   public void sahne1()
    {
        SceneManager.LoadScene(2);
    }
   public void sahne2()
    {
        SceneManager.LoadScene(3);
    }
    public void anaMenu()
    {
        SceneManager.LoadScene(0);
    }

}
