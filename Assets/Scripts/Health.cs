using System;
using UnityEngine;
using UnityEngine.Events;

public class Health: MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    
    [SerializeField]
    private int startHealth;
    
    private int currHealth;

    private UnityEvent dieEvent;

    public UnityEvent DieEvent => dieEvent = new UnityEvent();

    private void Awake()
    {
        currHealth = startHealth;
    }

    public void TakeDamage(int value)
    {
        currHealth -= value;
        if (currHealth <= 0) Die();
    }

    private void Die()
    {
        // notify subscribers
        dieEvent.Invoke();
    }
}