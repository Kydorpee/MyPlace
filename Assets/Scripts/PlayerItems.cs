using System;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    [SerializeField] private int totalWood;
    [SerializeField] private float currentWater;
    private float waterLimit = 50f;

    

    public int TotalWood { get => totalWood; set => totalWood = value; }
    public float CurrentWater { get => currentWater; set => currentWater = value; }

    public void WaterLimit (float water)
    {

        if (currentWater <= waterLimit)
        {
            currentWater += water;
        }
        
    }

   
}
