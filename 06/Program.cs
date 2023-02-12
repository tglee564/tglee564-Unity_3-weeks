using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. 먹을 것 클래스를 만들어서 여러개 입력받습니다.(ReadLine)
            //-1. 5개의 음식을 입력 받습니다.
            //-2. 추가로 음식을 입력받는데, 5개의 음식 중 이미 있는 음식이면 제외됩니다.
            //예) a,b,c,d,e가 있는데 추가로 b가 입력됨
            //-> a,c,d,e가 된다.

            Foods Menu = new Foods(); //
            Menu.input();

        }
        class Foods //class 생성
        {
            public string[] theFoodsList; // theFoodsList라는 값을 생성

            public void input() // input이라는 메소드 생성
            {
                theFoodsList = new string[5]; // theFoosList 값에 배열을 부여.
                for(int indexnumber = 0; indexnumber < 5; indexnumber++) //5회까지 반복
                {
                    System.Console.Write("음식 이름 : "); // 해당 문자 출력
                    theFoodsList[indexnumber] = System.Console.ReadLine(); // 메뉴 이름 입력
                }
                System.Console.WriteLine(); //줄바꿈

                string newFoodsName; //추가 음식 이름 값을 생성
                System.Console.WriteLine("추가 음식 이름 : "); // 해당 문자 출력
                newFoodsName = System.Console.ReadLine(); // 추가 메뉴 이름 임력

                for(int indexnumber = 0; indexnumber < 5; indexnumber++) //5회까지 반복
                {
                    if(theFoodsList[indexnumber] == newFoodsName) //만약 추가 입력한 메뉴가 기존 메뉴에 있을 경우
                    {
                        theFoodsList[indexnumber] = ""; // 해당 값은 비워진다.
                        break;                          // 적용될 경우 for문을 빠져나온다.
                    }
                }

                System.Console.Write("남은 음식 : "); // 결과값 출력
                for (int indexnumber = 0; indexnumber < 5; indexnumber++) // 5회까지 반복
                {
                    System.Console.Write($"{theFoodsList[indexnumber]}"); // theFoodsList를 출력
                }
            }

        }
    }
}
