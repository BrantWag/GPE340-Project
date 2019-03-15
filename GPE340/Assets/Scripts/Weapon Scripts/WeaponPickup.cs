using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WeaponPickup : Pickup {

    // Variable to store which weapon a pickup is
    public Weapon weapon;

    protected override void onPickup(GameObject target) {
        WeaponHolder targetWeaponHolder = target.GetComponent<WeaponHolder>();
        if (targetWeaponHolder != null) {
            targetWeaponHolder.Unequip();
            targetWeaponHolder.EquipWeapon(weapon);
            base.onPickup(target);
        }
    }

}
