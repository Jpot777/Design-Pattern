using System.Collections;
using System.Collectinos.Generic;
using UnityEngine;

// === 야생호랑이 === //
public class WildTiger : ITiger
{
    public void Growl()
    {
        Debug.Log("호랑이 : 으르렁");
    }

    public void Run()
    {
        Debug.Log("호랑이 : 호다다닥");
    }
}