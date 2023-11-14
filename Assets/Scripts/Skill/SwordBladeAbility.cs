using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Abilities/SwordBladeAbility")]
public class SwordBladeAbility : Ability
{
    public int swordDamage;
    public float swordRange;
    public float hitForce;
    public Color swordHighlightColor;

    private SworBladeTriggerable rcSwordBlade;

    public override void Activate(GameObject obj)
    {
        //rcSwordBlade = obj.GetComponent<SworBladeTriggerable>();
        //rcSwordBlade.Initialize();
        //rcSwordBlade.swordDamage = swordDamage;
        //rcSwordBlade.swordRange = swordRange;
        //rcSwordBlade.hitForce = hitForce;
        //rcSwordBlade.
    }

    public override void TriggerAbility()
    {
        rcSwordBlade.Blade();
    }
}
