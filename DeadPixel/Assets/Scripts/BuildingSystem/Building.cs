using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Building",menuName = "Create Building")]
public class Building : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private string describtion;
    [SerializeField] private Costs costs;
    [SerializeField] private Stats stats;

    [SerializeField,Tooltip("model player will be wile placing it")] 
    private GameObject prototypeBuilding;
    [SerializeField] private GameObject finishBuilding;

    [SerializeField] private FlorDetctingMode florDetcting;
    [SerializeField] private LayerMask buildLayer;

    [SerializeField] private Bounds bounds;

    public string Name{get => name;}
    public string Describtion{get => describtion;}
    public Costs Costs{get => costs;}
    public Stats Stats{get => stats;}
    public GameObject PrototypeBuilding{get => prototypeBuilding;}
    public GameObject FinishBuilding{get => finishBuilding;}

    public FlorDetctingMode FlorDetcting { get => florDetcting;}

    public enum FlorDetctingMode{
        UseFinalObjectColider,
        UseCustomBounds
    }

    public LayerMask BuildMask{get => buildLayer;}

    public Bounds ColliderBounds{get => bounds;}



}
