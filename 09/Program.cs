using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            // public       - 외부에서 자유롭게 사용가능
            // private      - 나만 사용 가능
            // protected    - 지정된 인원만 사용 가능

            Classes myNewclass = new Classes();
            myNewclass.Writeschoolinfor("SBS게임아카데미");

        }
        class school
        {
            protected string SchoolName;
            private string TeacherName;

            protected void WriteSchoolName()
            {
                System.Console.WriteLine($"학교 이름 : {SchoolName}");
            }
        }
        class Classes : school
        {
            private string ClassName = "H반";

            public void Writeschoolinfor(string _schoolname)
            {
                SchoolName = _schoolname;

                WriteSchoolName();
                System.Console.WriteLine($"내 반은 {ClassName}");

            }
        }
    }
}
