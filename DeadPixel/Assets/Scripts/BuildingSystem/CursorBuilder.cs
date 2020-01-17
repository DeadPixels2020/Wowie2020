using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBuilder : MonoBehaviour
{
    [SerializeField] private Camera myCamera;

    private GameObject _selected;

    public GameObject Selected
    {
        get => _selected;
        set => _selected = value;
    }

    public ICursoreControler cursoreControler;


    private void Update() {
        if(_selected != null){
            Vector2 cursorPos = myCamera.ScreenToWorldPoint(Input.mousePosition);
            _selected.transform.position = cursorPos;

            if(cursoreControler != null){
                if(Input.GetMouseButton(0)){
                        
                    cursoreControler.OnLeftClick();

                }else if(Input.GetMouseButton(1)){

                    cursoreControler.OnRightClick();
                
                }

                cursoreControler.ScrolWheel((int) Input.mouseScrollDelta.y);
            }
        }
    }

}
