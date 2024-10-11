using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Race : MonoBehaviour
{
    private int m_health;
    protected int maxHealth;
    public int health { get => m_health; protected set => m_health = value > maxHealth ? maxHealth : value; }
    public virtual void Move(Vector3 direction, int speed)
    {
        transform.Translate(direction * speed);
    }
}
