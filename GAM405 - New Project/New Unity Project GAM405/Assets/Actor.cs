using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour, ITakesDamage
{
    [SerializeField]
    public int health;


    void TakesDamage(float damage)
    {
        throw new System.NotImplementedException();
    }

    void ITakesDamage.TakesDamage(float x, float test)
    {
        throw new System.NotImplementedException();
    }
}
