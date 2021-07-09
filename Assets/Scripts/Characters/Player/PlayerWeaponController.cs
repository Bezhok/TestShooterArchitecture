using UnityEngine;

namespace Characters.Player
{
    [RequireComponent(typeof(CharacterWeaponChanger))]
    public class PlayerWeaponController: MonoBehaviour
    {
        private CharacterWeaponChanger weaponChanger;

        private void Awake()
        {
            weaponChanger = GetComponent<CharacterWeaponChanger>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                weaponChanger.EquipRifle();

            if (Input.GetKeyDown(KeyCode.Alpha2))
                weaponChanger.EquipShotgun();

            if (Input.GetKeyDown(KeyCode.Alpha3))
                weaponChanger.EquipPistol();

            if (Input.GetMouseButtonDown(0))
                weaponChanger.CurrentWeapon.Use();
        }
    }
}