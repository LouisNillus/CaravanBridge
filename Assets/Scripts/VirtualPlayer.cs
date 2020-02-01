using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualPlayer : MonoBehaviour
{
    public static VirtualPlayer instance;

    public int money;
    public int iron;
    public int wood;
    public int nails;


    void Awake()
    {
        instance = this;
    }

    // Start
    void Start()
    {
        
    }

    // Update
    void Update()
    {
        
    }
}
