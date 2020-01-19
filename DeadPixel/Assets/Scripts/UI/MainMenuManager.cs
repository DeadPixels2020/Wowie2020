using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioManager au;
    public GameObject AuOn;
    public GameObject AuOff;

    //anime
    public Animator animator;

    //functions
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
    public void StopAllSound()
    {
        PlayerPrefs.SetInt("au", 0);
        au.SetAllsound(false);
        AuOn.SetActive(false);
        AuOff.SetActive(true);
    }
    public void MakeAllSound()
    {
        PlayerPrefs.SetInt("au", 1);
        au.SetAllsound(true);
        AuOn.SetActive(true);
        AuOff.SetActive(false);
    }
    private void Awake()
    {
        StartCoroutine(wait());
        if (!PlayerPrefs.HasKey("au"))
        {
            PlayerPrefs.SetInt("au", 1);
            AuOn.SetActive(true);
            AuOff.SetActive(false);
        }

        if (PlayerPrefs.GetInt("au") == 0)
        {
            au.SetAllsound(false);
            AuOn.SetActive(false);
            AuOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("au") == 1)
        {
            au.SetAllsound(true);
            AuOn.SetActive(true);
            AuOff.SetActive(false);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        au.PlaySound("MusicMainMenu");
    }
    //Ill do invisible here

    public List<GameObject> Imag;

    public void PutIn()
    {
        StartCoroutine(PutI(Imag[Random.Range(0, 13)]));
    }

    IEnumerator PutI(GameObject g)
    {
        g.SetActive(true);
        yield return new WaitForSeconds(.6f);
        g.SetActive(false);
    }
    private void Start()
    {
        foreach(GameObject a in Imag)
        {
            a.SetActive(false);
        }
    }
    public void GoToSecretScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
}
