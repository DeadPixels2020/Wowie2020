using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlaySceneManager : MonoBehaviour
{
    public Animator PLaySceneAnime;

    public void OpenWeapons()
    {
        PLaySceneAnime.SetInteger("Panels", 1);
    }
    public void CloseWeapons()
    {
        PLaySceneAnime.SetInteger("Panels", 2);
    }
    public void OpenSettings()
    {
        PLaySceneAnime.SetInteger("Panels", 3);
        StartCoroutine(waiting());
    }
    public void CloseSettings()
    {
        PLaySceneAnime.SetInteger("Panels", 4);
        Time.timeScale = 1;
    }
    public void OpenNoMatPanel()
    {
        PLaySceneAnime.SetInteger("Panels", 5);
        StartCoroutine(waiting());
    }
    public void CloseNoMatPanel()
    {
        PLaySceneAnime.SetInteger("Panels", 6);
        Time.timeScale = 1;
    }
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(.5f);
        Time.timeScale = 0;
    }
}
