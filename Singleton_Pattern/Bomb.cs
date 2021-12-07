using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour 
{
    public void Start()
    {

    }

    public void Exploded()
    {
        SoundManager.instance.PlayEffect(eEffect.None);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.Layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("Player Collision to Bomb");
            Exploded();
        }    
    }
}