using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Handler : MonoBehaviour
{
   public void yeniden_baslat()
    {
        //SceneManager.LoadScene(0);
        Application.LoadLevel(0);
    }
    public void cikis()
    {
        Application.Quit();
}
    public void menu()
    {
        Application.LoadLevel(2);
    }
}
