using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioManager au;

    //anime
    public Animator animator;

    //functions
    private void Start()
    {
        au.PlaySound("MusicMainMenu");
    }
    public void GoToPlayScene()
    {
        au.PlaySound("MenuClick");
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void GoToSettings()
    {
        au.PlaySound("MenuClick");
        animator.SetInteger("Panels", 1);
    }
    public void GoToCreators()
    {
        au.PlaySound("MenuClick");
        animator.SetInteger("Panels", 2);
    }
    public void CloseSettings()
    {
        au.PlaySound("MenuClick");
        animator.SetInteger("Panels", 3);
    }
    public void CloseCreators()
    {
        au.PlaySound("MenuClick");
        animator.SetInteger("Panels", 4);
    }
}
