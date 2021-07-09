using System;
using UnityEngine;


namespace Weapons
{
    public abstract class Projectile: MonoBehaviour
    {
        protected int damage;
        private Transform startPointTransform;
        private float maxRange;
        private Vector3 startPosition;
        private Vector3 startImpulse;

        // for example ExplosiveProjectile can deal damage in some area
        protected abstract void OnCollisionEnter(Collision other);
        
        public virtual void Launch()
        {
            GetComponent<Rigidbody>().AddForce(startImpulse, ForceMode.Impulse);
        }
        
        protected virtual void Update()
        {
            if (Vector3.Distance(startPosition, transform.position) > maxRange)
            {
                Destroy();
            }
        }

        public virtual void Destroy()
        {
            Destroy(gameObject);
        }
    }
}