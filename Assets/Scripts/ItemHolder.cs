using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemHolder : MonoBehaviour
{
    public ItemStatsSO EquippedItem { get; private set; }

    [SerializeField] private Image equippedItemImage;

    public void EquipNewItem(ItemStatsSO newItem)
    {
        EquippedItem = newItem;
        equippedItemImage.sprite = EquippedItem.ItemSprite;
    }
}
