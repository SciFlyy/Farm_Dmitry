using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SheepProperty", menuName = "ScriptableObjects/newSheepProperty")]
public class SheepProperty : ScriptableObject
{
    [SerializeField] private string sheepName;
    [SerializeField] public float speed;
    [SerializeField] public Material material;

    public string Name
    {
        get
        {
            if (sheepName == "")
            {
                Debug.LogWarning("No Sheep Name");
                return "None Name";
            }
            else
            {
                return sheepName;
            }
        }
        set
        {
            sheepName = value;
        }
    }

    public float Speed
    {
        get
        {
            if(speed == 0)
            {
                speed = 5f;
            }
            else
            {
                return speed;
            }
            return speed;
        }
       // private set
        //{
        //    speed = value;
       // }
    }

    //public Material Material { get { return material; } }
    public Material Material => material; // get сокращение

    //private void Awake()
    // {
        //Speed = 10;
     //   Material.color = material.color;

    // }

    
}
