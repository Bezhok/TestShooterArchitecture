using System;
using System.Security.Cryptography;
using UnityEngine;

namespace Weapons
{
    public class Bullet: Projectile
    {
        protected override void OnCollisionEnter(Collision other)
        {
            var otherHealth = other.gameObject.GetComponent<Health>();
            if (other.gameObject.GetComponent<Health>() != null)
            {
                otherHealth.TakeDamage(damage);
            }
            
            Destroy();
        }
    }
}