using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제
{
    class Address
    {
        public string a { get; set; }
        public void a_info()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("--------------------------");
        }
    }



    class Input : Address

    {
        public string Enter { get; set; }
        public void Information()
        {
            Console.WriteLine("이름 입력 : ");
            Console.WriteLine("전화 입력 : ");
            Console.WriteLine("주소 입력 : ");
        }


        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("메뉴를 입력하세요 >>> ");
                    string input = Console.ReadLine("", out a);
                    int.parse(input);

                    switch (a == 0)
                    {
                        case a == 0:
                            Console.WriteLine("주소 입력 : ");
                            a++;
                        case a == 1;
                    }
                }
            }
        }
    }
}


