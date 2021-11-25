using System;
using System.Collectinos.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // === A회사가 가지고 있는 Request 함수 === //
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    // === 요녀석이 중간다리 역할! === //
    class Adapter : Target
    {
        private Adaptee m_adaptee = new Adaptee();

        public override void Request()
        {
            m_adaptee.SpecificRequest();
        }
    }

    // === B회사에서 준비한 Request 함수 === //
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    class Program
    {
        static void Main()
        {
            // 부모                 자식
            Targret target = new Adapter();     // Target을 상속받은 Adapter 클래스
            target.Request();

            Console.ReadKey();
        }
    }
}

// 상황예시:) 만약 A회사에서 Target클래스에 있는 Request()를
// B회사에 있는 Request()를 한동안 사용해야한다고 한다.
// 그럼 Request함수를 다시 만들어야할까?  Nopppe
// 같은 기능을 다른 방법으로 사용해야한다고 가정할 때 '중간다리'역할을 하는 녀석만 있으면 해결!

// 간단한 예시로 110V충전기 가져왔는데 콘센트가 220V용이야.. 어떡함
// 돼지코(Adapter)가 있으면 해결! 여기서 돼지코(Adapter)가 '중간다리' 역할!
// 그렇다면 110V(Target) 전기사용() 함수를 220V(Adaptee) 전기사용() 함수로 대체하게 되는것!!