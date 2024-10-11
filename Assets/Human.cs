using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human: Race
{
    public void Start()
    {
        maxHealth = 90;
        health = maxHealth;
    }
    public override void Move(Vector3 direction, int speed)
    {
        transform.Translate(direction * speed);
    }
}
