using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class RacerTyper : ScriptableObject
{
    //public TypeOfRacer typeOfRacer;

    [Header("Visual Settings")]
    public Sprite sprite;


    [Header("Movement Settings")]
    public Direction direction;
    [Range(0,300)]
    public float forceApplied;

    [Header("Physics Settings")]
    [Range(0, 50)]
    public float mass = 1;
    [Range(0, 10)]
    public float gravity = 1;
    
    [Header("Damages Settings")]
    [Range(0,100)]
    public int minDmg;
    [Range(0,100)]
    public int maxDmg;   

    [Header("Rewards Settings")]
    public Reward reward;
    [Range(0, 100)]
    public int amount;

    //public enum TypeOfRacer {Caravan, Goldy, Boss}
    public enum Direction {Left, Right}
    public enum Reward {NoReward, Wood, Iron, Nails, Money}
}
