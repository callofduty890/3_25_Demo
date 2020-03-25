using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_里氏转换_is_as
{
    //父类
    class Friut
    {

    }
    //子类
    class Apple:Friut
    {
        public void EatApple()
        {
            Console.WriteLine("我是苹果的吃法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1）子类可以赋值给父类
           //这里隐藏着一个东西，如果有一个地方需要父类作为参数，我们可以给一个子类代替
            Friut fr = new Apple();
            //object->string 
            //object->list
            //string str = string.Join("|", new string[] { "1", "2", "3" });
            //Console.WriteLine(str);

            //2)如果父类中装的是子类对象，那么可以将这个父类强转为子类
            Apple ap = (Apple)fr;
            ap.EatApple();
            Console.WriteLine();
            

            Console.ReadKey();

        }
    }
}
