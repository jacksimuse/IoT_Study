# 1번 문제 곱셈
```C#
 // 세자리 숫자를 받아온다 
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            // 첫 세자리 숫자
            int c = int.Parse(a);
            
            // 두번째 세자리 숫자를 각 자리마다 나눠준다
            int d = int.Parse(b.Substring(2));
            int e = int.Parse(b.Substring(1,1));
            int f = int.Parse(b.Substring(0,1));

            // 뒤에서부터 곱해준다
            int third = c * d; // 세자리 곱하기 1의자리
            int second = c * (e * 10); // 세자리 곱하기 10의 자리
            int first = c * (f * 100) ; // 세자리 곱하기 100의자리

            int total = first + second + third; 
            Console.WriteLine(third);
            Console.WriteLine(second);
            Console.WriteLine(first);

            Console.WriteLine(total); // 각 자리 합
```

# 2번 문제 나머지
```C#
// 숫자 3개를 받아온다
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(); // 한 줄 띄우기용

            // 그대로 표현했다..
            Console.WriteLine((a + b) % c);
            Console.WriteLine((a % c) + (b % c) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine((a % c) * (b % c) % c);
```
