using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvMgmt : MonoBehaviour
{
    public void GotoStart()
    {
        SceneManager.LoadScene("Lv1");
    }
    public void GotoLv1()
    {
        SceneManager.LoadScene("Lv1");
    }
    public void GotoLv2()
    {
        SceneManager.LoadScene("Lv2");
    }
    public void GotoLv3()
    {
        SceneManager.LoadScene("Lv3");
    }
    public void GotoLv4()
    {
        SceneManager.LoadScene("Lv4");
    }
    public void GoStartPage()
    {
        SceneManager.LoadScene("startmenu");
    }

}
