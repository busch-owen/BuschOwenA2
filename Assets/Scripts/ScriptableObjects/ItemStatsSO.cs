using UnityEngine;

[CreateAssetMenu(menuName = "ItemStats", fileName = "Item Stats")]
public class ItemStatsSO : ScriptableObject
{
    [field: SerializeField] public string ItemName { get; private set; }
    [field: SerializeField] public ItemType ItemType { get; private set; }
    [field: SerializeField, TextArea] public string ItemDescription { get; private set; }
    [field: SerializeField] public Sprite ItemSprite { get; private set; }
}

public enum ItemType
{
    Key, Weapon
}
