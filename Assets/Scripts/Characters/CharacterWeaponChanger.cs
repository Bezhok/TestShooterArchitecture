using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Weapons;

namespace Characters
{
    public class CharacterWeaponChanger: MonoBehaviour
    {
        // in case we have shooter with fixed amount of guns in inventory (one gun per type) 
        [SerializeField] 
        private Weapon rifle, shotgun, pistol; //melee

        [SerializeField] 
        private Transform weaponPosTransform;
        
        protected List<Weapon> weapons;
        protected Weapon currentWeapon;

        public int WeaponCount()
        {
            return weapons.Count;
        }
    
        public Weapon CurrentWeapon => currentWeapon;

        private void Awake()
        { 
            weapons = new List<Weapon>();
            weapons.Add(rifle);
            weapons.Add(shotgun);
            weapons.Add(pistol);

            foreach (var weapon in weapons)
            {
                weapon.UnEquip();
            }
        
            currentWeapon = rifle;
            currentWeapon.Equip(weaponPosTransform);
        }

        public void EquipRifle()
        {
            SwapWeapon(rifle);
        }

        public void EquipShotgun()
        {
            SwapWeapon(shotgun);
        }

        public void EquipPistol()
        {
            SwapWeapon(pistol);
        }

        protected void SwapWeapon(Weapon newWeapon)
        {
            if (currentWeapon == newWeapon) return;
        
            currentWeapon.UnEquip();
            currentWeapon = newWeapon;
            currentWeapon.Equip(weaponPosTransform);
        }

        public void SwapWeapon(int newWeaponId)
        {
            if (!Enumerable.Range(0, WeaponCount() - 1).Contains(newWeaponId))
            {
                throw new IndexOutOfRangeException();
            }

            SwapWeapon(weapons[newWeaponId]);
        }
    }
}
