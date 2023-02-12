using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. 학생 클래스를 만들어서 for문으로 학생 여럿을 입력받는다.
            Studentreadline[] students = new Studentreadline[2];

            for (int i = 0; i < 2; i++)
            {
                students[i] = new Studentreadline();
                students[i].inputstudentinfordata();
            }
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
    }
}
