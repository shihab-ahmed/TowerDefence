using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemCost;
    [SerializeField] private Image itemImage;
    [SerializeField] private GameObject towerPrefab;

    public void SetShopItemDetails(string itemName, int itemCost, Sprite itemSprite, GameObject towerPrefab)
    {
        this.itemName.text = itemName;
        this.itemCost.text = "Gold: "+itemCost;
        this.itemImage.sprite = itemSprite;
        this.towerPrefab = towerPrefab;
    }
    public void OnClickedBuildButton()
    {
        Debug.Log("Trying to place: " + towerPrefab.name);
    }
}
