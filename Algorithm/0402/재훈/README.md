# X보다 작은 수
이해가 잘안되서 도와주실분...

# A + B
```C#
		int t = int.Parse(Console.ReadLine()); // 테스트 케이스의 개수 T
		for (int i = 1; i <= t; i++)
		{
			string[] two_num = Console.ReadLine().Split(); //두 수를 문자배열로 받아온다
			Console.WriteLine($"Case #{i}: {int.Parse(two_num[0]) + int.Parse(two_num[1])}"); 
			// i가 진행되면서 첫번째 수와 두번째 수를 더해주면서 T만큼 진행된다
		}
```