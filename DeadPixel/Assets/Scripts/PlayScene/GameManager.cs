using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int Material;

    public GameObject NotEnoughCash;

    private BuildSystem buildSystem;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject trap;
    [SerializeField] private GameObject turet1;
    [SerializeField] private GameObject turet2;
    [SerializeField] private GameObject turet3;
    [SerializeField] private GameObject turet4;
    [SerializeField] private GameObject turet5;
    [SerializeField] private GameObject turet6;

    public void GoToMainMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex: 0);
	}
    public void BuyTurret1()
    {
        if (Material - 10 >= 0)
        {
            Material -= 10;
            buildSystem.Select(Instantiate(turet1));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTurret2()
    {
        if (Material - 20 >= 0)
        {
            Material -= 20;
            buildSystem.Select(Instantiate(turet2));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTurret3()
    {
        if (Material - 50 >= 0)
        {
            Material -= 50;
            buildSystem.Select(Instantiate(turet3));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTurret4()
    {
        if (Material - 100 >= 0)
        {
            Material -= 100;
            buildSystem.Select(Instantiate(turet4));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTurret5()
    {
        if (Material - 200 >= 0)
        {
            Material -= 200;
            buildSystem.Select(Instantiate(turet5));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTurret6()
    {
        if (Material - 500 >= 0)
        {
            Material -= 500;
            buildSystem.Select(Instantiate(turet6));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyTrap()
    {
        if (Material - 50 >= 0)
        {
            Material -= 50;
            buildSystem.Select(Instantiate(trap));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
    public void BuyBarrier()
    {
        if (Material - 10 >= 0)
        {
            Material -= 10;
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            buildSystem.Select(Instantiate(wall, pos, Quaternion.identity));
        }
        else
        {
            Time.timeScale = 0f;
            NotEnoughCash.SetActive(true);
        }
    }
}
