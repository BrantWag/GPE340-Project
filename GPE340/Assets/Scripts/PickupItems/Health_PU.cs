using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Health_PU : Pickup {

    public float healAmount;

protected override void onPickup(GameObject target)
{

    Health targetHealth = target.GetComponent<Health>();
    if (targetHealth == null)
    {
        // Do Nothing
    }
    else
    {
        //heal targert for set flaot amount
        targetHealth.Heal(healAmount);
    }

    base.onPickup(target);
}

}
