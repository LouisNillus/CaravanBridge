using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemsTyper : ScriptableObject
{
    public Sprite sprite;
    public string name;
    [Range(0,250)]
    public int ironCost;
    [Range(0,250)]
    public int woodCost;
    [Range(0,250)]
    public int fabricCost;
    [Range(0,250)]
    public int goldCost;
}
