using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShopUI))]
public class ShopManager : MonoBehaviour
{
    [SerializeField] private ShopUI shopUI;
    [SerializeField] private List<GameObject> towerList;
    
    public List<GameObject> GetTowerList()
    {
        return towerList;
    }
    private void Start()
    {
        shopUI = GetComponent<ShopUI>();
        GameObject[] prefabs = LoadAllPrefabs("Towers/");
        for (int i = 0; i < prefabs.Length; i++)
        {
            if (prefabs[i] == null) continue;
            if(prefabs[i].GetComponent<Tower>())
            {
                towerList.Add(prefabs[i]);
            }

        }
        if(towerList.Count > 0 && shopUI)
        {
            shopUI.CreateShopItem(towerList);
        }
        Debug.Log(prefabs.Length);
    }
    GameObject LoadPrefab(string path)
    {
        return Resources.Load<GameObject>(path);
    }
    GameObject[] LoadAllPrefabs(string path)
    {
        return Resources.LoadAll<GameObject>(path);
    }
}
