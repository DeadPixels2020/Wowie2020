using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlaySceneManager : MonoBehaviour
{
    public AudioManager au;

    public Animator PLaySceneAnime;
    public GameObject DethUI;
    public GameObject ErrorPanel;

    private void Awake()
    {
        DethUI.SetActive(false);
        ErrorPanel.SetActive(false);
    }
    public void OpenWeapons()
    {
        PLaySceneAnime.SetInteger("Panels", 1);
        au.PlaySound("MenuClick");
    }
    public void CloseWeapons()
    {
        PLaySceneAnime.SetInteger("Panels", 2);
        au.PlaySound("MenuClick");
    }
    public void OpenSettings()
    {
        PLaySceneAnime.SetInteger("Panels", 3);
        au.PlaySound("MenuClick");
        StartCoroutine(waiting());
    }
    public void CloseSettings()
    {
        PLaySceneAnime.SetInteger("Panels", 4);
        au.PlaySound("MenuClick");
        Time.timeScale = 1;
    }
    public void OpenNoMatPanel()
    {
        PLaySceneAnime.SetInteger("Panels", 5);
        au.PlaySound("MenuClick");
        StartCoroutine(waiting());
    }
    public void CloseNoMatPanel()
    {
        PLaySceneAnime.SetInteger("Panels", 6);
        au.PlaySound("MenuClick");
        Time.timeScale = 1;
    }
    public void OpenDeth()
    {
        DethUI.SetActive(true);
        PLaySceneAnime.SetInteger("Panels", 7);
        au.PlaySound("MenuClick");
    }
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(.5f);
        Time.timeScale = 0;
    }
}
