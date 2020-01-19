using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

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

    private void Start() {
        PlayerPocket.Pocket.AddToPocket(new Costs(999999));
        PlayerPocket.Pocket.AddToPocket(new Costs(1));
    }

    public void GoToMainMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex: 0);
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
