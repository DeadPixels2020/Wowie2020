using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioManager audio;
    public BuilderContoller builder;

    private void Awake()
    {
        audio.Init();
        audio.SetAllsound(true);
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
        builder.Make(0);
    }
    public void BuyTurret2()
    {
        builder.Make(1);
    }
    public void BuyTurret3()
    {
        builder.Make(2);
    }
    public void BuyTurret4()
    {
        builder.Make(3);
    }
    public void BuyTurret5()
    {
        builder.Make(4);
    }
    public void BuyTurret6()
    {
        builder.Make(5);
    }
    public void BuyTrap()
    {
        builder.Make(6);
    }
    public void BuyBarrier()
    {
        builder.Make(7);
    }
}
