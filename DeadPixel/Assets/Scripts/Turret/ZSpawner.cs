using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZSpawner : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject LetYouGo;
    public GameObject MyNameIs;
    public GameObject OtherPanel;
    public GameObject WhatPanel;
    public GameObject NoPanel;

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void Panel0()
    {
        MainPanel.SetActive(false);
    }
    public void Panel1()
    {
        MainPanel.SetActive(false);
        OtherPanel.SetActive(false);
    }
    public void Panel2()
    {
        MainPanel.SetActive(false);
        OtherPanel.SetActive(false);
        WhatPanel.SetActive(false);
    }
    public void Panel3()
    {
        MainPanel.SetActive(false);
        OtherPanel.SetActive(false);
        WhatPanel.SetActive(false);
        NoPanel.SetActive(false);
    }
    public void Panel4()
    {
        LetYouGo.SetActive(false);
    }
}
