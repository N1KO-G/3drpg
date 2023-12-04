using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    public ItemClass[] classItems;
    public ItemStruct[] structItems;
}
[System.Serializable]
public class ItemClass
{
    public int value;
    public string itemName;
}
[System.Serializable]
public struct ItemStruct
{
    public int value;
    public string itemName;
}
