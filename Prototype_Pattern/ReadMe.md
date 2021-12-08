### 2. Prototype Pattern

- 용도 :
  미리 만들어진 객체를 복사해서 객체를 생성하는 방식이다.
  객체를 많이 만들어야 할 경우, 객체 생성에 드는 코딩 분량을 현저히 줄일 수 있다!
  즉, 클래스로부터 객체를 생성하기 어려운 경우에 사용하면 좋다!

- 요약 :
  쉽게 말해 새로운 오브젝트를 지속적으로 new로 생성하는건 부담스러운 일!
  때문에 싼 비용인 본래의 오브젝트의 복사본을 만들어 내어(서로 다른 인스턴스),
  각 객체에 따라 데이터 수정을 해주는 방식으로 생성해 준다!

- 구조 :
  ex1)
  최초로 객체를 생성해주고
  다음 생성시 최초 생성했던 객체로부터 본사본(Clone())을 만든 후 수정해준다!

1. IUnit 인터페이스 => void Clone();
2. SCV 클래스 : IUnit 인터페이스 => IUnit Clone() { return this.MemberwiseClone() as IUnit; }
3. Probe 클래스 : IUnit 인터페이스 => IUnit Clone() { return this.MemberwiseClone() as IUnit; }

SCV scv = new SCV();
scv.HP = 100;
scv.Attack = 10;

// === 아래와 같이 최초로 생성했던 scv로부터 Clone() 하여 내용 수정 === //
SCV scvClone = (SCV)scv.Clone();
scv.HP = 60;
scv.Attack = 5;

ex2) In Unity

1.  void CreateUnit()
    {
    GameObject obj = Instantiate(unit);
    obj.transform.position = tf.position;
    }
