using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AStartScanner : MonoBehaviour
{
    public AstarPath path;
    public float gridUpdateTime;

    void Start()
    {
        InvokeRepeating("UpdatePath",gridUpdateTime,gridUpdateTime);
    }

    private void UpdatePath(){
        Debug.Log("ScanStart");
        path.Scan();
        Debug.Log("ScanComplete");
    }
}
