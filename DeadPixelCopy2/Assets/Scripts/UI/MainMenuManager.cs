using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    //anime
    public Animator animator;

    //functions
    private void Start()
    {

    }
    public void GoToPlayScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void GoToSettings()
    {
        animator.SetInteger("Panels", 1);
    }
    public void GoToCreators()
    {
        animator.SetInteger("Panels", 2);
    }
    public void CloseSettings()
    {
        animator.SetInteger("Panels", 3);
    }
    public void CloseCreators()
    {
        animator.SetInteger("Panels", 4);
    }
}
