using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    public Inventory inventory;

    public Text nameCharacter;
    public Text inventoryShort;
    public Text inventoryDescription;
    void Update()
    {
        nameCharacter.text = inventory.nameOfCharacter;
        inventoryShort.text = inventory.inventoryShort;
        inventoryDescription.text = inventory.inventoryDescription;
    }
}
