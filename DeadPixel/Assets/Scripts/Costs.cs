using UnityEngine;

[System.Serializable]
public class Costs{

    [SerializeField] private int matirial;

    public Costs(){
        matirial = 0;
    }
    public Costs(int matirial){
        this.matirial = matirial;
    }

    public int Matirial{
        get => matirial;
    }

}