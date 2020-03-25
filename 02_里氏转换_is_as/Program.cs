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
    //子类-apple
    class Apple:Friut
    {
        public void EatApple()
        {
            Console.WriteLine("我是苹果的吃法");
        }
    }
    //子类-Banana
    class Banana :Friut
    {
        public void EatBanana()
        {
            Console.WriteLine("我是香蕉的吃法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1）子类可以赋值给父类
            //这里隐藏着一个东西，如果有一个地方需要父类作为参数，我们可以给一个子类代替
            //Friut fr = new Banana();
            Friut fr = new Apple();
            //object->string 
            //object->list
            //string str = string.Join("|", new string[] { "1", "2", "3" });
            //Console.WriteLine(str);

            //2)如果父类中装的是子类对象，那么可以将这个父类强转为子类
            //is的做法
            if (fr is Apple==true)
            {
                Apple ap = (Apple)fr;
                ap.EatApple();
            }
            else
            {
                Console.WriteLine("is 转化失败");
            }

            //as
            //Friut Fr = new Apple();
            Friut Fr = new Banana();
            Banana ba = Fr as Banana;
            if (ba==null)
            {
                Console.WriteLine("as 转换失败");
            }
            else
            {
                ba.EatBanana();
            }

            

            Console.WriteLine();
            

            Console.ReadKey();

        }
    }
}
