using System;
using UnityEngine;

namespace Weapons
{
    public class Gun: Weapon
    {
        [SerializeField]
        private int damage;
    
        [SerializeField]
        private float maxRange;
    
        [SerializeField]
        private int fireRate; //bullets per second
    
        [SerializeField]
        private float spread;
    
        [SerializeField]
        private int magazineSize;
    
        [SerializeField]
        private float speed = 1f;
        
        [SerializeField]
        private Bullet bulletPrefab;
        
        private int awailableBulletCount;
        private int currentBulletCountInMagazine;


        private void Awake()
        {
            bulletPrefab.gameObject.SetActive(false);
        }

        public override void Use()
        {
            // if (timeSinceLastCall > 1/fireRate)
            {
                if (currentBulletCountInMagazine == 0)
                {
                    Reload();
                }
            
                SpawnBullet();
                currentBulletCountInMagazine--;
            }
        }

        public void Reload()
        {
            if (magazineSize > awailableBulletCount)
            {
                currentBulletCountInMagazine = awailableBulletCount;
                awailableBulletCount = 0;
            }
            else
            {
                awailableBulletCount -= magazineSize;
                currentBulletCountInMagazine = magazineSize;
            }
        }
    
        private void SpawnBullet()
        {
            // var bullet = Instantiate(bulletPrefab);
            // bullet.startImpulse = transform.forward*speed + new Vector3(0, Rand(-spread/2, spread/2), Rand(-spread/2, spread/2));
            // bullet.maxRange = maxRange;
            // bullet.startPoint = gun.position;
            // bullet.damage = damage
            // bullet.Launch();
        }
    }
}