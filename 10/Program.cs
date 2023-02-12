using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.식당 클래스를 상속받는 한식/양식/중식
            //식당 클래스가 전체적으로 가질 정보들을 갖는다
            //돈받기 / 주문한 음식 주기
            //각각 식당들은 메뉴가 모두 다르다
            //한식은 삼계탕 1만원 등등 다르다
            //가고싶은 식당을 입력받고 메뉴를 모두 띄워준다
            //유저는 메뉴를 입력하고 내야할 가격, 고른 메뉴를 띄워준다. 

            System.Console.WriteLine("어떤 요리를 먹을까?");
            System.Console.WriteLine("1.한식   2.양식  3. 중식");
            string Menus = System.Console.ReadLine();
            int Menus2 = Convert.ToInt32(Menus);

            if(Menus2 == 1)
            {
                Ko MyMenu = new Ko();
                MyMenu.Menusetting();
                MyMenu.ShowMenu();

                System.Console.WriteLine();
                System.Console.Write("먹을 음식은 몇 번? :");
                int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                MyMenu.OrderMenu(inputMenu);
            }
            else if (Menus2 == 2)
            {
                En MyMenu = new En();
                MyMenu.Menusetting();
                MyMenu.ShowMenu();

                System.Console.WriteLine();
                System.Console.Write("먹을 음식은 몇 번? :");
                int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                MyMenu.OrderMenu(inputMenu);
            }
            else
            {
                Ch MyMenu = new Ch();
                MyMenu.Menusetting();
                MyMenu.ShowMenu();

                System.Console.WriteLine();
                System.Console.Write("먹을 음식은 몇 번? :");
                int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
                MyMenu.OrderMenu(inputMenu);
            }
        }

        class Restaurant
        {
            protected string[] Menu;
            protected int[] Price; 

            public void TakeMoney(int Money)
            {
                System.Console.WriteLine($"돈 내기 : {Money}");
            }

            public void OrderMenu(int Number)
            {
                System.Console.WriteLine($"주문 : {Menu[Number]}");
                TakeMoney(Price[Number]);
            }

            public void ShowMenu()
            {
                System.Console.WriteLine($"종류 : ");
                for (int index = 0; index < Menu.Count(); index++)
                {
                    System.Console.WriteLine($"{Menu[index]}");
                }
            }
        }
        class Ko : Restaurant
        {
            public void Menusetting()
            {
                Menu = new string[2];
                Menu[0] = "1.밥";
                Menu[1] = "2.국";

                Price = new int[2];
                Price[0] = 1000;
                Price[1] = 8000;
            }
        }
        class En : Restaurant
        {
            public void Menusetting()
            {
                Menu = new string[2];
                Menu[0] = "1. 스테이크";
                Menu[1] = "2. 와인";

                Price = new int[2];
                Price[0] = 10000;
                Price[1] = 300000;
            }
        }
        class Ch : Restaurant
        {
            public void Menusetting()
            {
                Menu = new string[2];
                Menu[0] = "1. 짜장면";
                Menu[1] = "2. 짬뽕";

                Price = new int[2];
                Price[0] = 4000;
                Price[1] = 4500;
            }
        }
    }
}
