using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderContoller : MonoBehaviour,ICursoreControler
{
    public List<Building> buildingModel;

    [SerializeField] private CursorBuilder cursor;
    [SerializeField] private GameObject containerPrefab;
    [SerializeField] private Building building; // TEMP
    [SerializeField] private float rotationSensativity;

    private BuildingContainer buildingContainer;

    private void Awake()
    {
        //cursor.cursoreControler = this;
    }
    public void Make(int Model)
    {
        building = buildingModel[Model];
        cursor.cursoreControler = this;
        OnSelected();
    }

    private void OnSelected(){
        GameObject container = Instantiate(containerPrefab,Vector3.zero,Quaternion.identity);

        buildingContainer = container.GetComponent<BuildingContainer>();
        buildingContainer.BuildingModel = building;
        buildingContainer.InstansiatePrototype();

        cursor.Selected = container;
    }

    private void OnDeselected(){
        buildingContainer.DestroyPrototype();
        Destroy(buildingContainer.gameObject);
        building = null;
        cursor.Selected = null;
    }

    private void OnBuild(){

        if( !TryToPlace() )
            return;

        if( !PlayerPocket.Pocket.TryToPay(buildingContainer.BuildingModel.Costs) )
            return;

        buildingContainer.FinalBuild();
        building = null;
        cursor.Selected = null;

    }

    private void Start()
    {
        //OnSelected();
    }

    public void OnRightClick()
    {
        if(building == null)
            return;

        OnDeselected();
    }

    public void OnLeftClick()
    {
        if(building == null)
            return;

        OnBuild();
    }

    public void ScrolWheel(int cheng)
    {
        Vector3 rotation = buildingContainer.transform.localEulerAngles;

        rotation.z += cheng * rotationSensativity;

        buildingContainer.transform.transform.localEulerAngles = rotation;
    }


    private bool TryToPlace(){

        Collider2D hit = null;

        switch(building.FlorDetcting){

            case Building.FlorDetctingMode.UseFinalObjectColider:

            Collider2D collider = building.FinishBuilding.GetComponent<Collider2D>();
            hit = Physics2D.OverlapArea(buildingContainer.transform.position + collider.bounds.min, buildingContainer.transform.position + collider.bounds.max,building.BuildMask);
            Debug.Log( "min : "+collider.bounds.min);

            break;
            case Building.FlorDetctingMode.UseCustomBounds:

            hit = Physics2D.OverlapArea(building.ColliderBounds.min + buildingContainer.transform.position,building.ColliderBounds.max + buildingContainer.transform.position,building.BuildMask);

            break;

        }
        Debug.Log(hit != null ? hit.name : "null");

        return hit == null;

    }
}
