using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public UIPlaySceneManager UIPlay;

    public PlayerPocket pocket;
    public BuilderContoller builder;
    /*[SerializeField] private GameObject wall;
    [SerializeField] private GameObject trap;
    [SerializeField] private GameObject turet1;
    [SerializeField] private GameObject turet2;
    [SerializeField] private GameObject turet3;
    [SerializeField] private GameObject turet4;
    [SerializeField] private GameObject turet5;
    [SerializeField] private GameObject turet6;*/

    public void GoToMainMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex: 0);
	}
    public void BuyTurret1()
    {
        if (pocket.Matirial >= 10)
        {
            //pocket.Pay();
            builder.Make(0);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret2()
    {
        if (pocket.Matirial >= 20)
        {
            //pocket.Pay();
            builder.Make(1);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret3()
    {
        if (pocket.Matirial >= 40)
        {
            //pocket.Pay();
            builder.Make(2);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret4()
    {
        if (pocket.Matirial >= 60)
        {
            //pocket.Pay();
            builder.Make(3);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret5()
    {
        if (pocket.Matirial >= 100)
        {
            //pocket.Pay();
            builder.Make(4);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTurret6()
    {
        if (pocket.Matirial >= 150)
        {
            //pocket.Pay();
            builder.Make(5);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyTrap()
    {
        if (pocket.Matirial >= 40)
        {
            //pocket.Pay();
            builder.Make(6);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
    public void BuyBarrier()
    {
        if (pocket.Matirial >= 20)
        {
            //pocket.Pay();
            builder.Make(7);
        }
        else
        {
            UIPlay.OpenNoMatPanel();
        }
    }
}
