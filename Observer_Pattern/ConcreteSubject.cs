using System;
using System.Collections.Generic;

///<summary>
/// 옵저버들이 구현해야 할 인터페이스 메서드
///</summary>
public abstract class Observer
{
    public abstract void OnNotify();
}

///<summary>
/// 옵저버 구현 클래스 #1
///</summary>
public class ConcreteObserver1 : Observer
{
    public override void OnNotify()
    {
        Console.WriteLine("옵저버 클래스의 매서드 실행#1");
    }
}

///<summary>
/// 옵저버 구현 클래스 #2
///</summary>
public class ConcreteObserver2 : Observer
{
    public override void OnNotify()
    {
        Console.WriteLine("옵저버 클래스의 매서드 실행#2");
    }
}

///<summary>
/// 옵저버 관리, 활용에 관한 타입 정의
///</summary>
public interface ISubject
{
    void AddObserver(Observer o);       // 메세지 뿌릴 옵저버 추가
    void RemoveObserver(Observer o);    // 메세지 뿌릴 옵저버 삭제
    void Notify();                      // 옵저버들에게 연락하는 함수
}

///<summary>
/// 대상 인터페이스를 구현한 클래스
///</summary>
public class Subject : ISubject
{
    List<Observer> observers = new List<Observer>();
    Observer obj1 = null;
    Observer obj2 = null;

    public void AddObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o)
    {
        if (observers.IndexOf(o) > 0)
        {
            observers.Remove(o);
        }
    }

    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.OnNotify();
        }
    }

    public void Play()
    {
        obj1 = new ConcreteObserver1();
        obj2 = new ConcreteObserver2();

        AddObserver(obj1);
        AddObserver(obj2);
    }
}