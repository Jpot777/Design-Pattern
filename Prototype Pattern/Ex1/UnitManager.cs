using UnityEngine.Collections;
using UnityEngine.Collections.Generic;
using System;

public class UnitManager : MonoBehaviour 
{
    private void Start() 
    {
        // === Original === //
        SCV scv = new SCV();
        scv.Hp = 60;
        scv.AttackPower = 5;
        scv.Armor = 0;
        // === Original === //

        // === Clone === //
        SCV scvClone = (SCV)scv.Clone();        // Get Original SCV
        scvClone.Hp = 100;
        scvClone.AttackPower = 10;
        scvClone.Armor = 1;
        // === Clone === //

        Debug.Log("SCV Details");
        Debug.Log("HP : {0} / AttackPower : {1} / Armor : {2}",
                    scv.Hp, scv.AttackPower, scv.Armor);
        
        Debug.Log("Cloned SCV Details");
        Debug.LogFormat("HP : {0} / AttackPower : {1} / Armor : {2}",
                        scvClone.Hp, scvClone.AttackPower, scvClone.Armor);
    }    
}