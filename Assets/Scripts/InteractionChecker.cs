using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractionChecker : MonoBehaviour
{
    [SerializeField] private TMP_Text interactionStatus;

    [SerializeField] private Button attackButton;
    [SerializeField] private Button keyButton;

    private void Awake()
    {
        attackButton.onClick.AddListener(delegate { CheckInteraction(ItemType.Weapon);});
        keyButton.onClick.AddListener(delegate { CheckInteraction(ItemType.Key);});
    }

    public void CheckInteraction(ItemType requiredItemType)
    {
        var itemHolder = FindObjectOfType<ItemHolder>();

        if (itemHolder.EquippedItem == null)
        {
            interactionStatus.text = "No Item Equipped";
            return;
        }
        if (itemHolder.EquippedItem.ItemType != requiredItemType)
        {
            interactionStatus.text = "Incorrect Item Type";
            return;
        }

        interactionStatus.text = itemHolder.EquippedItem.ItemType switch
        {
            ItemType.Key => "You unlocked the chest",
            ItemType.Weapon => "You have slain the monster",
            _ => interactionStatus.text
        };
    }
}
