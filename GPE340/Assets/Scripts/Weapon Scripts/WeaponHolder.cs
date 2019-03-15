using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{

    // Variables
    public Weapon start_Weapon;
    public Transform holdPoint;
    private Weapon equippedWeapon;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        EquipWeapon(start_Weapon);
    }

    public void EquipWeapon(Weapon weapon)
    {
        equippedWeapon = Instantiate(weapon) as Weapon;
        equippedWeapon.transform.SetParent(holdPoint);
        equippedWeapon.transform.localPosition = weapon.transform.localPosition;
        equippedWeapon.transform.localRotation = weapon.transform.localRotation;

    }

    public void Unequip()
    {
        if (equippedWeapon)
        {
            Destroy(equippedWeapon.gameObject);
            equippedWeapon = null;
        }
    }

    protected void OnAnimatorIK(int layerIndex)
    {

        if (!equippedWeapon)
            return;
        // Block for right hand holding points using IK
        if (equippedWeapon.RHPoint)
        {
            anim.SetIKPosition(AvatarIKGoal.RightHand, equippedWeapon.RHPoint.position);
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);
            anim.SetIKRotation(AvatarIKGoal.RightHand, equippedWeapon.RHPoint.rotation);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, 1f);
        }
        else //set to zero
        {
            anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 0f);
            anim.SetIKRotationWeight(AvatarIKGoal.RightHand, 0f);
        }

        //block for left hand holding points using IK 
        if (equippedWeapon.LHPoint)
        {
            anim.SetIKPosition(AvatarIKGoal.LeftHand, equippedWeapon.LHPoint.position);
            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);
            anim.SetIKRotation(AvatarIKGoal.LeftHand, equippedWeapon.LHPoint.rotation);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1f);
        }
        else //set to zero
        {
            anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0f);
            anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0f);
        }
    }
}