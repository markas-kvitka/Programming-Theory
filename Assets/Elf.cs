using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Elf : Race
{
    public void Start()
    {
        maxHealth = 90;
        health = maxHealth;
    }
    public override void Move(Vector3 direction, int speed)
    {
        transform.Translate(direction * 2 * speed);
    }
}
