using System;

public class AdapterPattern : MonoBehaviour 
{
    private void Start() 
    {
        Poodle poodle = new Poodle();                   // IDog를 상속받은 클래스
        WildTiger tiger = new WildTiger();              // ITiger를 상속받은 클래스
        IDog tigerAdapter = new TigerAdapter(tiger);    
        // 여기서 바로 위의 줄(9)이 왜 될까?
        // TigerAdapter는 IDog를 상속받은 클래스이다. 그래서 할당 가능!
        // 그런데 여기서 중요! 
        // TigerAdapter의 생성자를 보면 ITiger를 매개변수로 갖는다.
        // 그래서 ITiger(부모)를 상속받은 WildTiger(자식)를 매개변수로 넣어준 것이다! => 인터페이스 상속이긴 하지만 클래스인 경우도 포함!
        // OOP 5대 원칙:) 3번. 리스코프 치환 원칙 => 부모클래스에 들어갈 자리에 자식클래스를 넣어도 잘 구동되어야 한다는 원칙.

        Debug.Log("푸들(강아지) 능력 사용");
        UseAnimal(poodle);

        Debug.Log("강아지 능력말고 호랑이 능력 사용해보고 싶음");
        UseAnimal(tigerAdapter);    
        // TigerAdapter를 거쳐 WildTiger의 기능을 대신 사용 가능!
    }

    private void UseAnimal(IDog dog)
    {
        dog.Bark();
        dog.Run();
    }
}

// 정리하자면 아래와 같다!
// 기존에 IDog 가 기준이 된다는 전재하에,
// 위 인터페이스(IDog)를 상속받는 강아지 클래스들이 존재하고,
// (Poodle과 같은 종류의 클래스들이 있다는 가정!)
// Bark(), Run() 함수를 사용중이었다!

// 그런데 여기서 IDog 객체가 가진 능력 말고
// WildTiger 객체의 능력을 한 번 사용 해보고 싶다!
// 그렇다면 WildTiger 클래스에 있는 Bark(), Run()에 접근해야하는데 바로 접근은 불가능..
// 그래서 필요한게 바로 중간다리 역할을 해줄 어댑터 클래스(TigeerAdapter)
// 여기서 왕중요! 어댑터가 될 클래스는 반.드.시. 기준이 되었던 클래스/인터페이스를 상속받는 클래스여야 중간다리 역할 가능!!
