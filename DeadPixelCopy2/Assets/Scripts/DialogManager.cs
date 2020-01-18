using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DialogManager : MonoBehaviour
{

    public Text sentenceBox;
    private DialogsScriptableObject Dialog;
    private FadeInUI fadeInUI;
    private FadeOutUI fadeOutUI;
    public GameObject DialogButton;
    bool nextSentenceActive = false;
    [System.NonSerialized] public bool writing = false;
    [SerializeField] bool DebugMode;
    [SerializeField] DialogsScriptableObject TestDialog;
    //[SerializeField] GameObject Player;

    void Start()
    {
        fadeInUI = gameObject.GetComponent<FadeInUI>();
        fadeOutUI = gameObject.GetComponent<FadeOutUI>();
        if (DebugMode)
        {
            Dialog = TestDialog;
        }
        //Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (DebugMode)
        {
            if (Input.GetMouseButtonDown(1))
            {
                StartDialog(Dialog);
            }
        }
        if ((Input.GetKeyDown("e") || Input.GetMouseButtonDown(0)) && nextSentenceActive)
        {
            if (writing)
                writing = false;
            else
                DisplayNextSentence();
        }
    }

    public void StartDialog(DialogsScriptableObject dialogScriptableObject)
    {
        //Player.GetComponent<PlayerBehavior>().enabled = false;
        StopAllCoroutines();
        nextSentenceActive = true;
        DialogButton.SetActive(nextSentenceActive);
        Dialog = dialogScriptableObject;
        Debug.Log(Dialog.textDialog);
        fadeInUI.StartFadeingUI();
        StartCoroutine(TypeSentence(Dialog.textDialog));
    }

    public void DisplayNextSentence()
    {
        if (Dialog.EndScene == true)
        {
            if (Dialog.nextSentences != null)
            {
                Dialog = Dialog.nextSentences;
            }
            EndDialog();
            return;
        }
        else
        {
            Dialog = Dialog.nextSentences;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(Dialog.textDialog));
        }
    }

    IEnumerator TypeSentence(string Sentence)
    {
        writing = true;
        yield return new WaitForSeconds(0.1f);
        sentenceBox.text = "";
        foreach (char letter in Sentence.ToCharArray())
        {
            if (writing == false)
            {
                sentenceBox.text = Sentence;
                break;
            }
            sentenceBox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        writing = false;
    }

    private void EndDialog()
    {
        sentenceBox.text = "";
        fadeOutUI.StartFadeingUI();
        nextSentenceActive = false;
        DialogButton.SetActive(nextSentenceActive);
        StopAllCoroutines();
        
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(1);
    }


}
