using UnityEngine;

namespace Weapons
{
    public abstract class Weapon: MonoBehaviour
    {
        public void Equip(Transform newTransform)
        {
            gameObject.SetActive(true);
        
            transform.SetParent(newTransform);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public void UnEquip()
        {
            gameObject.SetActive(false);
        }

        // shot/hit with melee/throw grenade
        public abstract void Use();
    }
}