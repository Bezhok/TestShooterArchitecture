using System.Collections;
using UnityEngine;

namespace Characters.AI
{
    [RequireComponent(typeof(CharacterWeaponChanger))]
    public class AIWeaponController: MonoBehaviour
    {
        private CharacterWeaponChanger weaponChanger;

        private void Awake()
        {
            weaponChanger = GetComponent<CharacterWeaponChanger>();
        }
    
        private  void Start()
        {
            int idx = Random.Range(0, weaponChanger.WeaponCount()-1);
            weaponChanger.SwapWeapon(idx);

            StartCoroutine(AttackWithDelay(1f));
        }

        private IEnumerator AttackWithDelay(float waitTime)
        {
            while (true)
            {
                yield return new WaitForSeconds(waitTime);
            
                // changeGunDirection(target: player)
                weaponChanger.CurrentWeapon.Use();
            }
        }
    }
}
