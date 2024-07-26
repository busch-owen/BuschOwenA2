using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Transform inventoryGrid;
    
    public void AddToInventory(GameObject newItem)
    {
        Instantiate(newItem, inventoryGrid);
    }
}
