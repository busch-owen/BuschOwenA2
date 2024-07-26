using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [field: SerializeField] public ItemStatsSO ItemStats { get; private set; }
    private Button _interactButton;

    [SerializeField] private TMP_Text itemNameText;
    [SerializeField] private Image itemImage;
    
    private UpdateDetails _details;

    private void Start()
    {
        itemImage.sprite = ItemStats.ItemSprite;
        itemNameText.text = ItemStats.ItemName;
        
        _interactButton = GetComponentInChildren<Button>();
        _details = FindObjectOfType<UpdateDetails>();
        _interactButton.onClick.AddListener(delegate{_details.Refresh(this);});
    }
}
