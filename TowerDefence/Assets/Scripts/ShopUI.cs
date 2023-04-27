using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopUI : MonoBehaviour
{
    [SerializeField] private GameObject ShopItemTemplatePrefab;
    [SerializeField] private GameObject contentPanel;
    [SerializeField] private TextMeshProUGUI playerGoldText;
    [SerializeField] private List<GameObject> ShopItems;

    public void CreateShopItem(List<GameObject> towers)
    {
        playerGoldText.text = "Gold: "+Player.Instance.CurrentMoney;
        ClearExistingShopItem();
        foreach (var towerObj in towers)
        {
            GameObject shopGameObject = Instantiate(ShopItemTemplatePrefab, contentPanel.transform);
            if (shopGameObject == null)
            {
                Debug.LogError("shopGameObject is null");
                continue;
            }
            ShopItem shopItem = shopGameObject.GetComponent<ShopItem>();
            Tower tower = towerObj.GetComponent<Tower>();
            if (shopItem == null)
            {
                Debug.LogError("shopItem is null");
                continue;
            }
            if (tower == null)
            {
                Debug.LogError("tower is null");
                continue;
            }
            shopItem.SetShopItemDetails(tower.name, tower.GetBuildCost(), tower.GetTowerSprite(), towerObj);
            ShopItems.Add(shopGameObject);
        }
    }
    private void ClearExistingShopItem()
    {
        if(ShopItems == null)
        {
            ShopItems = new List<GameObject>();
            return;
        }
        else
        {
            foreach (var item in ShopItems)
            {
                Destroy(item);
            }
        }
        ShopItems.Clear();
    }
    public void Start()
    {
        
    }
}
