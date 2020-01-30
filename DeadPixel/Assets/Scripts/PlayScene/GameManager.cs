using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioManager audio;
    public GameObject AuOn;
    public GameObject AuOff;
    public UIPlaySceneManager UIPlay;


    public BuilderContoller builder;
    /*[SerializeField] private GameObject wall;
    [SerializeField] private GameObject trap;
    [SerializeField] private GameObject turet1;
    [SerializeField] private GameObject turet2;
    [SerializeField] private GameObject turet3;
    [SerializeField] private GameObject turet4;
    [SerializeField] private GameObject turet5;
    [SerializeField] private GameObject turet6;*/

    public void StopAllSound()
    {
        PlayerPrefs.SetInt("au", 0);
        audio.SetAllsound(false);
        AuOn.SetActive(false);
        AuOff.SetActive(true);
    }
    public void MakeAllSound()
    {
        PlayerPrefs.SetInt("au", 1);
        audio.SetAllsound(true);
        AuOn.SetActive(true);
        AuOff.SetActive(false);
    }
    private void Awake()
    {
        audio.Init();

        if(!PlayerPrefs.HasKey("au"))
        {
            PlayerPrefs.SetInt("au", 1);
            AuOff.SetActive(false);
            AuOn.SetActive(true);
        }

        if(PlayerPrefs.GetInt("au") == 0)
        {
            audio.SetAllsound(false);
            AuOn.SetActive(false);
            AuOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("au") == 1)
        {
            audio.SetAllsound(true);
            AuOn.SetActive(true);
            AuOff.SetActive(false);
        }
    }

    public void GoToBugScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    public void restart()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
        Time.timeScale = 1;
    }
    public void GoToMainMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex: 1);
	}
    public void BuyTurret1()
    {
        if (PlayerPocket.Pocket.Matirial >= 10)
        {
            builder.Make(0);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret2()
    {
        if (PlayerPocket.Pocket.Matirial >= 20)
        {
            builder.Make(1);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret3()
    {
        if (PlayerPocket.Pocket.Matirial >= 40)
        {
            builder.Make(2);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret4()
    {
        if (PlayerPocket.Pocket.Matirial >= 60)
        {
            builder.Make(3);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret5()
    {
        if (PlayerPocket.Pocket.Matirial >= 100)
        {
            builder.Make(4);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret6()
    {
        if (PlayerPocket.Pocket.Matirial >= 150)
        {
            builder.Make(5);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTrap()
    {
        if (PlayerPocket.Pocket.Matirial >= 40)
        {
            builder.Make(6);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyBarrier()
    {
        if (PlayerPocket.Pocket.Matirial >= 20)
        {
            builder.Make(7);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
}
