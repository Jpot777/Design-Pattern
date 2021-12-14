using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Facade_Pattern
{
    // === A동작을 위한 클래스 === //
    class SubSystemOne 
    {
        public void MethodOne() 
        {
            Console.WriteLine(" SubSystemOne Method");
        }
    }
 
    // === B동작을 위한 클래스 === //
    class SubSystemTwo 
    {
        public void MethodTwo() 
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
    }
 
    // === C동작을 위한 클래스 === //
    class SubSystemThree 
    {
        public void MethodThree() 
        {
            Console.WriteLine(" SubSystemThree Method");
        }
    }
 
    // === D동작을 위한 클래스 === //
    class SubSystemFour 
    {
        public void MethodFour() 
        {
            Console.WriteLine(" SubSystemFour Method");
        }
    }
    
    class Facade 
    {
        private SubSystemOne one;
        private SubSystemTwo two;
        private SubSystemThree three;
        private SubSystemFour four;
 
        public Facade() 
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }
 
        public void MethodA() 
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
 
        public void MethodB() 
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
    
            Console.ReadKey();
        }
    }
}
