using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory")]
public class Inventory : ScriptableObject
{
    public string nameOfCharacter;
    public string inventoryShort;
    public string inventoryDescription;
}
