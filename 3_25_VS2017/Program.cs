using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_25_VS2017
{
    //创建基类 - 
    class Person
    {
        //姓名
        private string _name;
        //性别
        private string _gender;
        //年龄
        private int _age;


        //属性
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //生活属性
        public void Live()
        {
            Console.WriteLine("吃 喝 拉 撒 睡");
        }

        //构造函数
        public Person(string name, string gender, int age)
        {
            Console.WriteLine("Person 的有参构造函数被调用");
            this.Name = name;
        }
    }

    //创建学生对象
    class Student : Person
    {
        //班级
        private int _Class;

        public int Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        //学习属性
        public void Study()
        {
            Console.WriteLine("看书 敲代码 复习");
        }
        //子类的构造函数
        public Student(string name, string gender, int age)
            : base(name, gender, age)
        {
            Console.WriteLine("Student 有参构造函数被调用");

        }



    }

    //创建老师对象
    class Teacher 
    {
        //工号
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //工作属性
        public void Hard_Work()
        {
            Console.WriteLine("上课 备课 准备作业");
        }
    }

    //创建老司机
    class Dirve 
    {
        private int _Driving_age;

        public int Driving_age
        {
            get { return _Driving_age; }
            set { _Driving_age = value; }
        }


        public void Work()
        {
            Console.WriteLine("每天都在开车 天天都在开车");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student dr = new Student("鬼鲛", "雌雄同体", 18);
            dr.Live();
            Console.ReadKey();
        }
    }
}
