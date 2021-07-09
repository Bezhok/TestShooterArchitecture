using System;
using System.Security.Cryptography;
using UnityEngine;

namespace Weapons
{
    public class Bullet: MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);
        }
    }
}