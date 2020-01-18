using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Dialogs", menuName = "Dialogs")]
public class DialogsScriptableObject : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] public string textDialog;
    [SerializeField] public DialogsScriptableObject nextSentences;
    [SerializeField] public bool EndScene;

}
