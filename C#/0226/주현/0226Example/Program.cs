using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0226Example
{
    /*
     * 0. 주소 입력 
     * 1. 주소 검색
     * 2. 주소 수정
     * 3. 주소 삭제
     * 4. 주소 전체 출력
     * 5. 프로그램 종료
     * 메뉴를 선택하세요 >>>
     */

    /*
     * 이름
     * 전화
     * 주소
     */
	
    class AddressBook
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }
        
    }

	class Initialize
	{
		public void Start()
		{
            Console.WriteLine("주소록입니다");
            Console.WriteLine("-------------------------");
			Console.WriteLine(" * 0. 주소 입력\n * 1. 주소 검색\n * 2. 주소 수정\n * 3. 주소 삭제\n * 4. 주소 전체 출력\n * 5. 프로그램 종료");
			Console.WriteLine("-------------------------");
			Console.Write("원하는 메뉴의 번호를 입력하세요 >>> ");
		}
	}

    class Insert : AddressBook//주소 입력
    {
        public void InsertAddr()
        {
            Console.WriteLine("주소 입력을 선택하셨습니다.");
            Console.Write("이름 : ");
            this.Name = Console.ReadLine();
            Console.Write("전화 : ");
            this.Phone = Console.ReadLine();
            Console.Write("주소 : ");
            this.Addr = Console.ReadLine();
        }
    }

    class Search : AddressBook//주소 검색
    {
        public void SearchAddr()
        {
            Console.WriteLine("주소 검색을 선택하셨습니다.");
            Console.Write("이름 : ");
            this.Name = Console.ReadLine();
            Console.Write("전화 : ");
            this.Phone = Console.ReadLine();
            Console.Write("주소 : ");
            this.Addr = Console.ReadLine();
        }
    }

    class Update : AddressBook //주소 수정
    {
        public void UpdateAddr()
        {
            Console.WriteLine("주소 수정을 선택하셨습니다.");
            Console.Write("이름 : ");
            this.Name = Console.ReadLine();
            Console.Write("전화 : ");
            this.Phone = Console.ReadLine();
            Console.Write("주소 : ");
            this.Addr = Console.ReadLine();
        }
    }

    class Delete : AddressBook //주소 삭제
    {
        public void DeleteAddr()
        {
            Console.WriteLine("주소 삭제를 선택하셨습니다.");
            Console.Write("이름 : ");
            this.Name = Console.ReadLine();
            Console.Write("전화 : ");
            this.Phone = Console.ReadLine();
            Console.Write("주소 : ");
            this.Addr = Console.ReadLine();
        }
    }

    class Print : AddressBook //주소 전체 출력
    {
        public void PrintAddr()
        {
            Console.WriteLine("주소 전체 출력을 선택하셨습니다.");
            Console.Write("이름 : ");
            this.Name = Console.ReadLine();
            Console.Write("전화 : ");
            this.Phone = Console.ReadLine();
            Console.Write("주소 : ");
            this.Addr = Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
			

            AddressBook[] addresses; //클래스의 배열 선언

            

            while (true)
            {
                Console.Clear();
                Initialize initial = new Initialize();
                initial.Start();

                string val = Console.ReadLine();
                int num = 0;
                int.TryParse(val, out num);
                Console.Clear();

                switch (num)
                {
                    case 0:
                        Insert ins = new Insert();
                        ins.InsertAddr();
                        //initial.Start();
                        break;
                    case 1:
                        Search srch = new Search();
                        srch.SearchAddr();
                        //initial.Start();
                        break;
                    case 2:
                        Update upd = new Update();
                        upd.UpdateAddr();
                        //initial.Start();
                        break;
                    case 3:
                        Delete del = new Delete();
                        del.DeleteAddr();
                        //initial.Start();
                        break;
                    case 4:
                        Print prt = new Print();
                        prt.PrintAddr();
                        //initial.Start();
                        break;
                        /*
                    case 5:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    default:
                        initial.Start();
                        break;
                        */
                }
                if (num == 5) break;
            }
            
        }
    }
}
