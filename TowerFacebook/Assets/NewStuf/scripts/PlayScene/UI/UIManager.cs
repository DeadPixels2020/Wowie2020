using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<GameObject> AllUIWeapons;
    public List<GameObject> UIOptions;
    public List<int> Prices;
    public RectTransform canv;

    int Check;
    int check2;
    float check3;
    int TestMat;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject w in AllUIWeapons)
        {
            int.TryParse(w.GetComponentInChildren<TextMeshProUGUI>().text, out TestMat);
            Prices.Add(TestMat);
        }
        AdjustWeapuns(PlayerPocket.Pocket.Matirial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AdjustWeapuns(int Mat)
    {
        canv.localScale = new Vector3(1, 1);
        canv.localPosition = new Vector3(0, 0);
        check3 = 0;
        check2 = 0;
        foreach (Transform t in canv)
        {
            Destroy(t.gameObject);
        }
        Check = 0;
        UIOptions = new List<GameObject>(0);
        foreach (GameObject w in AllUIWeapons)
        {
            Check += 1;
            if (Prices[Check - 1] <= Mat)
            {
                UIOptions.Add(w);
                check3 += 1f;
            }
        }
        if (check3 > 4)
        {
            canv.localScale = new Vector2(1 + (1f / 4f) * (check3 - 4), 1);
        }
        foreach (GameObject a in UIOptions)
        {
            check2 += 1;
            Make(a, check2 - 1f);
        }
        if (check3 > 4)
        {
            canv.localPosition = new Vector2(688f + (check3 - 4) * 172f, 0);
        }
    }
    public void Make(GameObject weapon, float Gnum)
    {
        if (check3 > 4)
        {
            GameObject a = Instantiate(weapon, new Vector3(90f - (688f / 8f) * (check3 - 4) + Gnum * 172f, 30f, 0), Quaternion.identity);
            a.transform.parent = canv;
        }
        else
        {
            GameObject a = Instantiate(weapon, new Vector3(90f + Gnum * 175f, 30f, 0), Quaternion.identity);
            a.transform.parent = canv;
        }
    }
    public void Reset()
    {
        canv.localScale = new Vector3(1, 1);
        canv.localPosition = new Vector3(0, 0);
        check3 = 0;
        check2 = 0;
    }
}
