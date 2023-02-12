using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            //나이에 해당하는 띠를 출력해줄 클래스를 만든다.
            //탄생 년도를 입력하면 해당하는 띠를 출력한다.
            //출력할때 만 나이계산되어 출력된다.

            Zodiac List = new Zodiac();
            List.Calculate();


        }
        class Zodiac
        {
            public string[] zodiacValue = new string[12] { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

        public void Calculate()
        {
            System.Console.WriteLine("탄생년도를 입력하세요");
            string year = System.Console.ReadLine();
            int year2 = Convert.ToInt32(year);

            int year3 = year2 % 12;
                System.Console.WriteLine($"당신은 {zodiacValue[year3]}띠이며, 현재 나이는 {2023 - year2}세 입니다.");

        }

        }


    }
}
