using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Class
            //student Astudent;
            //Astudent = new student();

            //Astudent.name = "이태근";
            //Astudent.age = 35;

            //System.Console.WriteLine($"제 이름은 {Astudent.name}입니다");
            //System.Console.WriteLine($"제 나이는 {Astudent.age}입니다");

            //student Bstudent = new student();

            //Bstudent.name = "닷군";
            //Bstudent.age = 1;

            //System.Console.WriteLine($"제 이름은 {Bstudent.name}입니다");
            //System.Console.WriteLine($"제 나이는 {Bstudent.age}입니다");

            //Astudent.Writelinestudentinfo();

            //1. 학생클래스를 만들어서 학생 하나의 정보(이름/나이)를 입력받는다.(Readline)

            //Studentreadline Cstudent;
            //Cstudent = new Studentreadline();

            //System.Console.WriteLine("이름을 입력하세요.");
            //Cstudent.name = System.Console.ReadLine();
            //System.Console.WriteLine("나이를 입력하세요.");
            //Cstudent.age = Convert.ToInt32(System.Console.ReadLine());

            //Cstudent.Writelinestudentinfo2();

            //2. 학생클래스를 만들어서 메소드로 학생 하나의 정보를 입력받는다.

            Studentreadline Astudent = new Studentreadline();
            Astudent.inputstudentinfordata();

        }
    }
    //class student
    //{   //필드
    //    public string name;
    //    public int age;

    //    public void Writelinestudentinfo()
    //    {
    //        System.Console.WriteLine($"학생의 이름은 {name}입니다");
    //        System.Console.WriteLine($"학생의 나이는 {age}입니다");
    //    }

    }
    class Studentreadline
    {
        public string name;
        public int age;

        public void Writelinestudentinfo2()
        {
            System.Console.WriteLine($"학생의 이름은 {name}입니다");
            System.Console.WriteLine($"학생의 나이는 {age}입니다");
        }

        public void inputstudentinfordata()
        {
            System.Console.WriteLine("이름을 입력하세요.");
            name = System.Console.ReadLine();
            System.Console.WriteLine("나이를 입력하세요.");
            age = Convert.ToInt32(System.Console.ReadLine());

            Writelinestudentinfo2();
        }
    }

