using UnityEngine;

namespace Characters
{
    [RequireComponent(typeof(Health))]
    public class Character: MonoBehaviour
    {
        private Health health;

        private void Awake()
        {
            health = GetComponent<Health>();
            health.DieEvent.AddListener(Die);
        }

        public void Die()
        {
            gameObject.SetActive(false);
        }
    }
}
