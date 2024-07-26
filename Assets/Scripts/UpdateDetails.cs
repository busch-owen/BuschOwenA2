using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateDetails : MonoBehaviour
{
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Image itemImage;

    private ItemStatsSO _currentSelectedItem;

    private ItemHolder _itemHolder;

    private void Start()
    {
        _itemHolder = FindObjectOfType<ItemHolder>();
    }
    
    public void Refresh(InventoryItem inventoryItem)
    {
        _currentSelectedItem = inventoryItem.ItemStats;
        nameText.text = _currentSelectedItem.ItemName;
        descriptionText.text = _currentSelectedItem.ItemDescription;
        itemImage.sprite = _currentSelectedItem.ItemSprite;
    }

    public void EquipItem()
    {
        if(_currentSelectedItem)
            _itemHolder.EquipNewItem(_currentSelectedItem);
    }
}
