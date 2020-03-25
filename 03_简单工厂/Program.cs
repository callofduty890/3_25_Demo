using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_简单工厂
{
    //1.建抽象产品
    class Friut
    {
        
    }
    //2.创建具体产品类
    class Apple:Friut
    {
        public void EatApple()
        {
            Console.WriteLine("苹果的吃法");
        }
    }
    class Banana : Friut
    {
        public void EatBanana()
        {
            Console.WriteLine("香蕉的吃法");
        }
    }
    class Pear : Friut
    {
        public void EatPear()
        {
            Console.WriteLine("雪梨的吃法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你喜欢吃的水果 1.苹果 2.香蕉 3.梨子");
            //接收用户输入的内容
            string reuslt = Console.ReadLine();

            //1.创建抽象产品类
            Friut fr=null;

            //3.创建工厂
            switch (reuslt)
            {
                case "苹果":
                    fr = new Apple();
                    break;
                case "香蕉":
                    fr = new Banana();
                    break;
                case "梨子":
                    fr = new Pear();
                    break;
            }

            //4.调用工厂类
            if (fr is Apple)
            {
               ((Apple)fr).EatApple();
            }

            if (fr is Banana)
            {
                ((Banana)fr).EatBanana();
            }

            if (fr is Pear)
            {
                ((Pear)fr).EatPear();
            }

            Console.ReadKey();
        }
    }
}
