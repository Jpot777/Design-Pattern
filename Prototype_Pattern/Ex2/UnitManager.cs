using UnityEngine.Collections;
using UnityEngine.Collections.Generic;
using UnityEngine;

public class SCV : MonoBehaviour
{
    private void Start() 
    {
        // === 시작할 때 색이 랜덤하게 선택됨! === //
        float r = Random.Range(0.0f, 1.0f);    
        float g = Random.Range(0.0f, 1.0f);    
        float b = Random.Range(0.0f, 1.0f);    

        Render rend = this.GetComponent<Render>();
        rend.material.color = new Color(r,g,b,0f);
        // === 시작할 때 색이 랜덤하게 선택됨! === //
    }

    private void OnCollisionEnter(Collision other) 
    {
        // === 어느 물체에 충돌하면 사라짐 === //
        Debug.Log("OnCollisionEnter");
        Destroy(this.gameObject);    
        // === 어느 물체에 충돌하면 사라짐 === //
    }
}