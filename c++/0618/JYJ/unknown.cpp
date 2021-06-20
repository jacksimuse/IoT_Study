using namespace std;

bool PrimeTable[10000000] = { false, };

// 소수 판별
bool isPrime(int n) {

	if (n <= 1)
		return false;

	int i;
	// n이 소수가 아니면 적어도 n제곱근 이하의 수를 약수로 가진다.
	/*
	n이 소수가 아니면 적어도 두 개 이상의 수의 곱으로 구성되므로 n = ab 라고 둘 수 있다.
	a <= b 이면 a*a <= a*b = n 이 성립된다. 따라서 a <= sqrt(n) 임은 자명하다.
	*/
	for (i = 2; i * i <= n; ++i)
		if (n % i == 0)
			break;

	if (i * i > n)
		return true;
	else
		return false;
}

// P(n, r) : n 개의 원소 중에 순서를 고려하여  r 개를 뽑는 방법
// STL을 이용한 코드 가독성이 개선된 백트래킹 전략
// n : 전체 n개의 원소 (벡터)
// tmp : 선택된 r개의 원소 (벡터)
// r : 뽑아야 되는 원소의 수
// ans : 정답의 개수
void perm_n_r(vector<int> n, vector<int> tmp, int r, int &ans) {

	// r이 0인 경우 : 원소 선택 완료됨 
	if (!r) {
		int value = 0;
		for (int element : tmp) {
			value *= 10;
			value += element;
		}
		cout << value << '\n';

		// 소수면 집합에 추가
		if (isPrime(value) && !PrimeTable[value]) {
			PrimeTable[value] = true;
			++ans;
		}

		return;
	}

	for (int i = 0; i < n.size(); ++i) {
		// 원소 선택(추출)
		int item = n[i];
		tmp.push_back(item);
		n.erase(n.begin() + i);

		// 선택 후 남은 원소들 백트래킹
		perm_n_r(n, tmp, r - 1, ans);

		// 원소 복구(선택한 원소)
		tmp.pop_back();
		n.insert(n.begin() + i, item);
	}
}

int main(int argc, char* argv[]) {
	
	string str("");

	vector<int> n; // 입력 벡터
	vector<int> tmp; // 임시 벡터 
	int ans = 0; // 정답

	// 문자열 입력
	cin >> str;

	// 문자열 -> 숫자 배열 변환
	for (char ch : str)
		n.push_back(ch - '0');

	// n개 원소 중 순서를 고려하여 1개, 2개, ... n개를 선택하여 만들어지는 숫자 조합 && 소수 판별 && 숫자 세기
	for(int r = 1; r <= n.size(); ++r)
		perm_n_r(n, tmp, r, ans);

	// 결과 출력
	cout << ans << '\n';

	return 0;
}
