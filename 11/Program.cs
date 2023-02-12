using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //9. 서점클래스에 제목, 지은이, 출판사를 입력받아 책 데이터를 쌓는다
            //특정키를 입력받을때까지 지속되며 특정 키 입력을 받으면 제목을
            //입력받고 제목에 맞는 지은이, 출판사를 순서대로 출력해준다.

            Library Library = new Library();

            int countBoNumber = 0;
            do
            {
                Library.InputBookData(countBoNumber);
                countBoNumber++;
            } while (Library.AskkeepPutData());

            Library.SearchTitle();


        }

        class Book
        {
            public string title;
            public string writer;
            public string publisher;
            public string price;
        }

        class Library
        {
            Book[] books = new Book[99];

            public void InputBookData(int BookCount)
            {
                books[BookCount] = new Book();

                System.Console.Write("제목 : ");
                books[BookCount].title = System.Console.ReadLine();

                System.Console.Write("지은이 : ");
                books[BookCount].writer = System.Console.ReadLine();

                System.Console.Write("출판사 : ");
                books[BookCount].publisher = System.Console.ReadLine();

                System.Console.Write("가격 : ");
                books[BookCount].price = System.Console.ReadLine();

                System.Console.WriteLine("------------------------");
            }
            public bool AskkeepPutData()
            {
                System.Console.Write("계속 입력할까요? (y/n) : ");
                string UserAnser = System.Console.ReadLine();

                if(UserAnser == "Y" || UserAnser == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void SearchTitle()
            {
                System.Console.Write("찾고 싶은 책의 제목 입력 : ");
                string UserAnser = System.Console.ReadLine();

                for (int indexNum = 0; indexNum < books.Count(); indexNum++)
                {
                    if (books[indexNum] == null)
                    {
                        System.Console.WriteLine("못 찾았습니다.");
                        break;
                    }

                    else if (books[indexNum].title == UserAnser)
                    {
                        System.Console.WriteLine($"제목 : {books[indexNum].title}");
                        System.Console.WriteLine($"지은이 : {books[indexNum].writer}");
                        System.Console.WriteLine($"출판사 : {books[indexNum].publisher}");
                        System.Console.WriteLine($"가격 : {books[indexNum].price}");
                        break;
                    }
                }
                
            }
            }
        }
    }
