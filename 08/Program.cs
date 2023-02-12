using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            // 게임들을 보유하고 있는 게임 클래스를 제작한다.
            // 게임을 입력하면 배열에 값이 있는지 비교해서 있는지 없는지 유무를 출력해준다.

            Game GameList = new Game();
            GameList.inputdata();


        }
        class Game
        {
            public string[] GameList;
            public void inputdata()
            {
                GameList = new string[5];
                for (int List = 0; List <5; List++)
                {
                    System.Console.Write("게임명 : "); // 해당 문자 출력
                    GameList[List] = System.Console.ReadLine(); // 메뉴 이름 입력
                }
                System.Console.WriteLine();

                string NewGame;
                System.Console.WriteLine("신규 게임명 : "); // 해당 문자 출력
                NewGame = System.Console.ReadLine(); // 추가 메뉴 이름 임력

                for (int List = 0; List < 5; List++) //5회까지 반복
                {
                    if (GameList[List] == NewGame) //만약 추가 입력한 메뉴가 기존 메뉴에 있을 경우
                    {
                        System.Console.WriteLine("해당 게임은 가지고 있습니다.");
                        break;                          // 적용될 경우 for문을 빠져나온다.
                    }
                    if (List == 4)
                    {
                        System.Console.WriteLine("해당 게임은 가지고 있지 않습니다.");
                        break;                          // 적용될 경우 for문을 빠져나온다.
                    }
                }
            }
        }
    }
}
