using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. 위에 했던 4,5,6,7,8를 메소드로 뽑아서 실행하기

            solution456();
            solution7();
            solution8();

            //10. for 문 안에서 숫자를 계속 입력받는다.
            //-1. 숫자가 10인 경우 break로 for문 종료
            //-2. 숫자가 짝수인경우 continue로 넘김
            //-3. 그 이외의 경우 "다음 숫자 입력"을 출력.

            System.Console.WriteLine("10번");
            
            for (int num = 0; num == 10; num++)
            {
                System.Console.WriteLine("숫자를 입력받는다.");
                string num0 = System.Console.ReadLine();
                int num1 = Convert.ToInt32(num0);
                int num2 = num1 % 2;

                if (num1 == 10)
                {
                    System.Console.WriteLine("Break");
                    break;
                }
                else if (num2 == 0)
                {
                    System.Console.WriteLine("Continue");
                    continue;
                }
                else
                {
                    System.Console.WriteLine("다음 숫자 입력");

                }


            }


        }

        static void solution456()
        {
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
        }
        static void solution7()
        {
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
        }
        static void solution8()
        {
            #region
            Console.WriteLine("숫자 입력 받은 수 만큼 문장 출력(for)");
            Console.WriteLine("숫자 입력");
            string num9 = Console.ReadLine();
            int num10 = Convert.ToInt32(num9);

            for (int num = 0; num < num10; num++)
            {
                System.Console.WriteLine(num);
            }

            System.Console.WriteLine("끝");

            #endregion
        }
    }
}
