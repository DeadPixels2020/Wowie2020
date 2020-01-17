using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingContainer : MonoBehaviour
{
    private Building buildingModel;

    public Building BuildingModel{ set => buildingModel = value; get => buildingModel;}

    private GameObject prototype;
    private GameObject finalBuild;

    public void InstansiatePrototype(){
        if(finalBuild !=null) return;

        prototype = Instantiate(buildingModel.PrototypeBuilding,transform.position,transform.rotation);
        prototype.transform.parent = transform;

    }

    public void DestroyPrototype(){
        if(finalBuild !=null || prototype == null) return;

        Destroy(prototype);
    }

    public void FinalBuild(){
        DestroyPrototype();
        finalBuild = Instantiate(buildingModel.FinishBuilding,transform.position,transform.rotation);
        finalBuild.transform.parent = transform;
    }
}
