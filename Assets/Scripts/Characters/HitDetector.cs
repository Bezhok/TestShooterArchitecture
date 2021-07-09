using UnityEngine;

namespace Characters
{
    [RequireComponent(typeof(Health))]
    public class HitDetector : MonoBehaviour
    {
        private Health health;

        private void Awake()
        {
            health = GetComponent<Health>();
        }

        private void OnCollisionEnter(Collision other)
        {
            // if (other is bullet)
            // {
            //     health.TakeDamage(bullet.damage);
            // }
        }
    }
}
