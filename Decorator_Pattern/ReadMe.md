### 5. Decorator Pattern

- 용도 :
  데코레이팅한 결과물을 다시 내용물로 보고 그것을 다시 데코레이팅하기 위한 것
  (지속적으로 장식을 추가할 때, 문자열 주위에 여러 유형의 Border 장식을 추가할 때)

- 요약 :
  본 객체에 추가적인 기능을 동적으로 유연하게 첨가하는 패턴!
  즉, 감싸고 감싸고 감싸고~~

- 사용방법 :
  Border 클래스가 다시 Display를 포함함(컴포지트랑 비슷!)

  장점 :
  객체에 동적으로 기능 추가가 간단하게 가능!

  단점 :
  클래스가 많아져 객체의 정체를 알기 힘들고 복잡해질 수 있다.