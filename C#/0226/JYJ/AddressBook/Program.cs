using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* 0 : 주소 입력 
 * 1 : 주소 검색
 * 2 : 주소 수정
 * 3 : 주소 삭제
 * 4 : 주소 전체 출력
 * 5 : 파일 읽기
 * 6 : 파일 쓰기
 * 7 : 프로그램 종료 */

namespace AddressBookApp
{
    class AddressBook
    {
        // idx, 이름, 전화, 주소 를 받는 정적 list
        // ValueTuple이 정의되어 있지 않으면 Nuget 패키지로 라이브러리를 추가한다.
        /* * * *
        NuGet은 마이크로소프트에서 비주얼 스튜디오에서 개발 확장으로 공개한 무료 오픈 소스 패키지 관리자 프로그램이다.
        비주얼 스튜디오 2012부터 NuGet이 기본적으로 사전 설치되어 있고, NuGet은 SharpDevelop과 통합되기도 한다.
        또한 명령줄에서 NuGet을 사용할 수 있으며 스크립트로 자동화할 수 있다.
        주로 닷넷 프레임워크의 패키지와 C++로 작성된 네이티브 패키지(CoApp 지원) 를 지원한다.
        * * * */
        private static List<(string, string, string)> list;

        // 정적 생성자
        static AddressBook()
        {
            // list 초기화 (1번만)
            list = new List<(string, string, string)>();
        }

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("------------------------");
            Console.WriteLine("[Address Book Ver 2.0]");
            Console.WriteLine("0. 입력");
            Console.WriteLine("1. 검색");
            Console.WriteLine("2. 수정");
            Console.WriteLine("3. 삭제");
            Console.WriteLine("4. 전체 출력");
            Console.WriteLine("5. 파일 불러오기");
            Console.WriteLine("6. 파일 저장하기");
            Console.WriteLine("7. 프로그램 종료");
            Console.WriteLine("------------------------");

            Console.Write("메뉴를 선택하세요 >>> ");
            bool is_Num = int.TryParse(Console.ReadLine(), out int number);
            if (is_Num)
            {
                switch (number)
                {
                    case 0:
                        Input();
                        break;

                    case 1:
                        Search();
                        break;

                    case 2:
                        Update();
                        break;

                    case 3:
                        Delete();
                        break;

                    case 4:
                        Print();
                        break;

                    case 5:
                        LoadBookFile();
                        break;

                    case 6:
                        SaveBookFile();
                        break;

                    case 7:
                        // 정상 종료
                        Environment.Exit(0);
                        break;

                    default:
                        // 비정상 종료
                        Environment.Exit(1);
                        break;
                }
            }
            else
            {
                return;
            }
        }

        // 입력
        public void Input()
        {
            string name, mobile, addr;
            Console.Clear();

            do
            {
                Console.WriteLine("------------------------");
                Console.Write("이름 (엔터 시 종료) : ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                Console.Write("전화 : ");
                mobile = Console.ReadLine();
                if (string.IsNullOrEmpty(mobile))
                    break;

                Console.Write("주소 : ");
                addr = Console.ReadLine();
                if (string.IsNullOrEmpty(addr))
                    break;
                Console.WriteLine("------------------------");

                list.Add((name, mobile, addr));
                // Console.WriteLine(list.ElementAt(list.Count - 1).Item1);
            } while (true);
        }

        // 검색
        public void Search()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, etc.종료) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                int count = 0;

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                count++;
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {count}건");
            }
        }

        // 수정
        public void Update()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("[수정할 영역 검색]");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, etc.종료) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                List<int> idx = new List<int>(); // idx 리스트 초기화

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {idx.Count}건");

                if (idx.Count > 0)
                {
                    if (idx.Count == 1)
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("이름 (엔터 시 수정취소) : ");
                        string name = Console.ReadLine();
                        if (string.IsNullOrEmpty(name))
                            continue;

                        Console.Write("전화 : ");
                        string mobile = Console.ReadLine();
                        if (string.IsNullOrEmpty(mobile))
                            continue;

                        Console.Write("주소 : ");
                        string addr = Console.ReadLine();
                        if (string.IsNullOrEmpty(addr))
                            continue;
                        Console.WriteLine("------------------------");
                        list[idx[0]] = ((name, mobile, addr));
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("변경할 인덱스 번호 : ");
                        bool is_Idx = int.TryParse(Console.ReadLine(), out int sel_idx);
                        if (is_Idx)
                        {
                            int Idx = idx.FindIndex(x => x == sel_idx);
                            if (Idx != -1)
                            {
                                Console.WriteLine("------------------------");
                                Console.Write("이름 (엔터 시 수정취소) : ");
                                string name = Console.ReadLine();
                                if (string.IsNullOrEmpty(name))
                                    continue;

                                Console.Write("전화 : ");
                                string mobile = Console.ReadLine();
                                if (string.IsNullOrEmpty(mobile))
                                    continue;

                                Console.Write("주소 : ");
                                string addr = Console.ReadLine();
                                if (string.IsNullOrEmpty(addr))
                                    continue;
                                Console.WriteLine("------------------------");
                                list[idx[Idx]] = ((name, mobile, addr));
                            }
                        }
                        else
                            continue;
                    }
                }

            }
        }

        // 삭제
        public void Delete()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("[삭제할 영역 검색]");
                Console.Write("검색 영역 선택(1.이름, 2.전화, 3.주소, 4.etc) : ");
                string select = Console.ReadLine();

                if (select.Contains('1') || select.Contains("이름"))
                    select = "1";
                else if (select.Contains('2') || select.Contains("전화"))
                    select = "2";
                else if (select.Contains('3') || select.Contains("주소"))
                    select = "3";
                else
                    break;

                Console.Write("검색 단어 : ");
                string search = Console.ReadLine();
                List<int> idx = new List<int>(); // idx 리스트 초기화

                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    switch (select)
                    {
                        case "1":
                            if (ptr.Item1.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "2":
                            if (ptr.Item2.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        case "3":
                            if (ptr.Item3.Contains(search))
                            {
                                Console.WriteLine($"인덱스 : {i}");
                                Console.WriteLine($"이름 : {ptr.Item1}");
                                Console.WriteLine($"전화 : {ptr.Item2}");
                                Console.WriteLine($"주소 : {ptr.Item3}");
                                Console.WriteLine("------------------------");
                                idx.Add(i);
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"검색 결과 : {idx.Count}건");

                if (idx.Count > 0)
                {
                    if (idx.Count == 1)
                    {
                        Console.Write("정말로 삭제할까요 ? (Y/N) : ");
                        string cmd = Console.ReadLine();
                        if (cmd.Contains('y') || cmd.Contains('Y'))
                            list.RemoveAt(idx[0]);
                        else
                        { }
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.Write("삭제할 인덱스 번호 : ");
                        bool is_Idx = int.TryParse(Console.ReadLine(), out int sel_idx);
                        if (is_Idx)
                        {
                            int Idx = idx.FindIndex(x => x == sel_idx);
                            if (Idx != -1)
                            {
                                Console.Write("정말로 삭제할까요 ? (Y/N) : ");
                                string cmd = Console.ReadLine();
                                if (cmd.Contains('y') || cmd.Contains('Y'))
                                    list.RemoveAt(idx[Idx]);
                                else
                                { }
                            }
                        }
                    }
                }

            }
        }

        // 전체 출력
        public void Print()
        {
            Console.Clear();

            string cmd;
            do
            {
                Console.WriteLine("------------------------");
                for (int i = 0; i < list.Count; i++)
                {
                    (string, string, string) ptr = list[i];
                    Console.WriteLine($"인덱스 : {i}");
                    Console.WriteLine($"이름 : {ptr.Item1}");
                    Console.WriteLine($"전화 : {ptr.Item2}");
                    Console.WriteLine($"주소 : {ptr.Item3}");
                    Console.WriteLine("------------------------");
                }
                Console.WriteLine($"총 {list.Count}건의 정보가 있습니다.\n");
                Console.Write("다시 보실래요? 나갈래요? (y/n) : ");
                cmd = Console.ReadLine();
            } while (cmd.Contains('y') || cmd.Contains('Y'));
        }

        /* * * *
        [using 키워드]

        1.지시문(Directive)
        
        다른 네임스페이스에 정의된 타입을 Import 하거나, 네임스페이스에 대한 별칭을 만들때 사용한다.

        using System.Text; //코드 상단에 네임스페이스 정의
        using Project = PC.MyCompany.Project; // 별칭
        
            
        2.문장(Statement) *

        개체의 범위를 정의할때 사용한다.그 범위를 벗어나면 자동으로 Dispose 된다.
        File이나 Font, DB Connection 관련 클래스들은 관리되자 않는 리소스에 액세스 합니다.다 사용후 적절하게 Dispose해서 자원을
        반납해야 합니다.하지만 종종 Dispose를 하지 않아서 리소스가 낭비되거나 DB Connection 같은 것을 Open만하고 Close하지 않으면
        문제가 발생합니다. 이때 일일이 Close하지 않고 Using을 이용하면 그 범위를 벗어나면 자동으로 Dispose 되서 관리가 쉬워집니다.
    
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
        * * * */

        // 파일 읽기
        public void LoadBookFile()
        {
            string readPath = @"AddressBook.txt";
            // 기록한 리스트가 없으면 읽기 금지
            if (!File.Exists(readPath))
                return;

            string[] list_rec = File.ReadAllLines(readPath);

            list = new List<(string, string, string)>(); // list 초기화

            Console.WriteLine("------------------------");
            Console.WriteLine("[읽은 목록들]");
            foreach (string rec in list_rec)
            {
                string[] words = rec.Split('\t');
                // Console.WriteLine("{0}", rec);
                Console.WriteLine("{0}({1}), {2}({3}), {4}({5})", 
                words[0], words[0].Length, words[1], words[1].Length, words[2], words[2].Length);
                list.Add((words[0], words[1], words[2]));
            }
            Console.WriteLine("------------------------");
            System.Threading.Thread.Sleep(3000);
        }

        // 파일 쓰기
        public void SaveBookFile()
        {
            string savePath = @"AddressBook.txt";
            // 기록할 리스트가 없으면 쓰기 금지
            if (list.Count == 0) 
                return;

            // 이미 파일이 존재하면 Append (덧붙이기)
            if (File.Exists(savePath))
            {
                using (StreamWriter outputFile = new StreamWriter(savePath, true))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        outputFile.WriteLine(list[i].Item1 + '\t' + list[i].Item2 + '\t' + list[i].Item3);
                    }
                    // outputFile.Dispose();
                    // outputFile.Close();
                }
            }
            // 파일이 존재하지 않으면 새로쓰기
            else
            {
                using (StreamWriter outputFile = new StreamWriter(savePath))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        outputFile.WriteLine(list[i].Item1 + '\t' + list[i].Item2 + '\t' + list[i].Item3);
                    }
                    // outputFile.Dispose();
                    // outputFile.Close();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();

            while (true)
                book.Menu();
        }
    }
}
