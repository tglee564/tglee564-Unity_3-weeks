using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Info information = new Info();

            int countnumber = 0;
            do
            {
                information.inputdata(countnumber);
                countnumber++;
            } while (information.AskkeepPutData());

            information.SearchClass();
        }
        class student
        {
            public string Name;
            public string Class;
        }
        class Info
        {
            student[] students = new student[99];

            public void inputdata(int Count)
            {
                students[Count] = new student();

                System.Console.Write("이름 : ");
                students[Count].Name = System.Console.ReadLine();

                System.Console.Write("반 : ");
                students[Count].Class = System.Console.ReadLine();

                System.Console.WriteLine("------------------------");
            }
            public bool AskkeepPutData()
            {
                System.Console.Write("계속 입력할까요? (y/n) : ");
                string UserAnser = System.Console.ReadLine();

                if (UserAnser == "Y" || UserAnser == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void SearchClass()
            {
                System.Console.Write("몇 반의 명단을 봅니까?");
                string UserAnser = System.Console.ReadLine();

                for (int indexNum = 0; indexNum < students.Count(); indexNum++)
                {
                    if (students[indexNum] == null)
                    {

                        System.Console.WriteLine("모두 찾았습니다.");
                        break;
                    }

                    else if (students[indexNum].Class == UserAnser)
                    {
                        System.Console.WriteLine($"{students[indexNum].Name}");
                    }
                }
            }
        }
    }
}
