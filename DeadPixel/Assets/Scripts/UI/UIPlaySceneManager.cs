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
    }
    public void CloseSettings()
    {
        PLaySceneAnime.SetInteger("Panels", 4);
    }
}
