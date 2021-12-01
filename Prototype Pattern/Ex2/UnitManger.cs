using UnityEngine.Collections;
using UnityEngine.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public GameObject unit;     // 버튼 눌러서 생성할 유닛 오브젝트
    public Transform tf;        // 첫 시작 위치 트랜스폼

    private void Start() 
    {
        
    }

    // === 버튼 이벤트 : 유닛 생성용 === //
    public void CreateUnit()
    {
        GameObject obj = Instantiate(unit);
        obj.transform.position = tf.position;
    }
}