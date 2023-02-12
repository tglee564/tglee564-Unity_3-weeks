using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 산술이항 하나씩 쓰기 + - * / %, 출력하기 5줄
            #region
            int number1 = 10;
            int number2 = 20;
            System.Console.WriteLine("A = 10, B=20");

            int Plus = number1 + number2;
            int Minus = number2 - number1;
            int mult = number1 * number2;
            int quio = number2 / number1;
            int remain = number2 % number1;

            System.Console.WriteLine($"Plus 값 = {Plus}");
            System.Console.WriteLine($"Minus 값 = {Minus}");
            System.Console.WriteLine($"Mult 값 = {mult}");
            System.Console.WriteLine($"quio 값 = {quio}");
            System.Console.WriteLine($"remain 값 = {remain}");
            #endregion

            //2. 할당 (+=, -= ...), 출력하기 5줄
            #region
            int number3 = 30;
            System.Console.WriteLine("값 30");

            number3 += 10;
            System.Console.WriteLine($"+= {number3}");
            number3 -= 10;
            System.Console.WriteLine($"-= {number3}");
            number3 *= 10;
            System.Console.WriteLine($"*= {number3}");
            number3 /= 10;
            System.Console.WriteLine($"/= {number3}");
            number3 %= 10;
            System.Console.WriteLine($"%= {number3}");
            #endregion

            //3. 증감 (++,--) 앞뒤로 4줄
            #region
            int number4 = 123;
            System.Console.WriteLine("값 123");
            Console.WriteLine($"1.++X {++number4}");
            Console.WriteLine($"2.X++ {number4++}");
            Console.WriteLine($"3.--X {--number4}");
            Console.WriteLine($"4.X-- {number4--}");
            #endregion

            //4. 2개 숫자 입력 후 a가 짝수이고 B가 5보다 큰가를 if 문으로
            //5. 2개 숫자 입력 후 a가 홀수이거나 B가 3보다 작은가를 else if문으로
            //6. else 문으로 없음 출력하기
            #region
            Console.WriteLine("A값 입력");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine("B값 입력");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);

            int num5 = num2 % 2;

            if (num5 <= 0)
            {
                if (num4 > 5)
                {
                    Console.WriteLine("A는 짝수이며 B값은 5보다 큽니다.");
                }
                else if (num4 < 5)
                {
                    Console.WriteLine("A는 짝수이며 B값은 5보다 작습니다.");
                }
            }
            else if (num5 >= 1)
            {
                if (num4 < 3)
                {
                    Console.WriteLine("A는 홀수이며 B값은 3보다 작습니다.");
                }
                else if (num4 > 3)
                {
                    Console.WriteLine("A는 홀수이며 B값은 3보다 큽니다.");
                }
            }
            else
            {
                Console.WriteLine("없음");
            }
            #endregion

            //7. 숫자 입력 받은 수 만큼 문장 출력(while)
            #region
            Console.WriteLine("숫자 입력 받은 수 만큼 문장 출력(while)");
            Console.WriteLine("숫자 입력");
            string num6 = Console.ReadLine();
            int num7 = Convert.ToInt32(num6);
            int num8 = 0;

            System.Console.WriteLine("시작");

            while (num8 < num7)
            {
                System.Console.WriteLine(num8);
                num8 += 1;
            }

            System.Console.WriteLine($"{num8} 끝");

            #endregion


            //8. 숫자 입력 받은 수 만큼 문장 출력(for)
            #region
            Console.WriteLine("숫자 입력 받은 수 만큼 문장 출력(for)");
            Console.WriteLine("숫자 입력");
            string num9 = Console.ReadLine();
            int num10 = Convert.ToInt32(num9);

            for (int num = 0; num < num10; num++ )
            {
                System.Console.WriteLine(num);
            }

            System.Console.WriteLine("끝");

            #endregion
        }
    }
}
