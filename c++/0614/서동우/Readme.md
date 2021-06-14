```C++
/*
	프로그래머스 lv2 큰 수 만들기

	구현
	1. 첫번째 for문으로 구해야할 숫자 개수만큼 돌림
	2. 두번째 for문에 answer에 대입할 최대값을 구함.
	3. 최대값을 answer에 대입
*/


#include <iostream>
#include <string>
#include <vector>
using namespace std;

string solution(string number, int k)
{
	string answer = "";
	int numsize = number.size() - k;  // 구해야할 숫자 개수

	int start = 0;     // 최대값을 구할때 시작 인덱스
	int end = k;       // 최대값을 구할때 끝날 인덱스(1씩 늘어남)

	int max = 0;       // 임시로 최대값을 담았다가 answer[i]에 대입할 변수
	int maxindex = 0;  // 최대값을 구했을때 인덱스값을 담을 임시 변수

	for (int i = 0; i < numsize; i++)  // 구해야할 숫자 개수만큼만 for문 돌림
	{
		for (int j = start; j <= end; j++) // answer[i]를 start~end 만큼 돌려서 최대값을 찾음
		{
			if (max < number[j])
			{
				max = number[j]; // 최대값을 임시 변수 max에 대입
				maxindex = j;    // 최대값의 인덱스를 임시변수 maxindex에 대입
			}
		}
		answer += max;           // 구한 최대값을 answer에 대입
		max = 0;                 // 임시 변수 값을 0으로 초기화

		start = maxindex + 1;    // (최대값 인덱스 + 1) 부터 최대값 비교 시작
		end++;                   // answer에 한 자리를 구했으므로 배제할 숫자가 하나 줄어들었으니 ++해줌
	}

	cout << answer << endl;
	return answer;  
}

int main()
{
	solution("1924", 2);
	solution("1231234", 3);
	solution("4177252841", 4);
	return 0;
}



/*
    두번째 for문 (1231234 예시) => start부터 end까지 돌림
    1231234 는 7자리 수, k는 3이므로 답은 4자리수를 반환해야한다.

    j = 0 일때
    맨뒤의 3자리수(234)중 하나라도 고르면 4자리가 성립되지않으므로
    앞의 1231 중에 큰 값을 골라야함.

     (  1    2    3    1   )   234
      start           end


    그중 최대값이 '3'이므로 '3'을 answer[0] 에 대입(answer += max;)
    이때 '3'의 인덱스값을 maxindex에 저장(if문의 maxindex = j; )

    두번째 for문이 끝나면서 
    - 임시변수 max 는 0으로 초기화
    - start의 값을 최대값의 위치 + 1 로 해줌 => 최대값인 '3'의 자리 다음부터 최대값을 비교하기때문
    - end 의 값을 ++해줌 => answer에 한자리가 채워졌으므로 구해야할 자리수는 4자리 -> 3자리가됬다
                       => 3자리가 됬으므로 배제해야할 숫자가 맨뒷자리의 '234' -> '34'가 됨
	
  

    j = 1 일때
    j = 0일때 최대값으로 '3'을 골랐으므로 3의 인덱스 + 1부터 비교를 시작
	  answer의 한자리를 구했으므로 '34'를 빼고 '12' 중에 최대값을 골라줌
    12   3  (   1    2   )  34
              start end

    '1', '2' 중에 '2'가 더 크므로 answer[1]자리에 '2'를 넣어주고
    임시변수들을 초기화해줌

    
    
    j = 2 일때
    2자리를 더 구해야하는데 남은 자릿수가 2자리이므로 그대로 '34'를 answer에 대입


    따라서 최대값이 '3234'가 출력
*/
```
