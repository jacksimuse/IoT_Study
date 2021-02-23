using System;


namespace _0223Review_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10035];
            int[] arr2 = new int[10035];
            int hap = 0;
            for (int i = 0; i < 10000; i++)
            {
                hap = i + (i / 1000) + (i / 100) - (i / 1000 * 10) + (i / 10) - (i / 100 * 10) + (i % 10);
                //Console.WriteLine("i " + i);
                //Console.WriteLine("hap " + hap);

                arr[i] = hap;
                //Console.WriteLine(arr[i]);
            }

            int q = 0;
            int answer = 1;

            while (answer < 10000)
            {
                /*
                 * 1부터 10000까지의 숫자를 비교, 같은수가 없으면 q가 0 있으면 0이 아닌점을 이용
                 */
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (answer == arr[i])
                    {//answer가 배열 안에 있다면 q를 증가시킨다
                        q++;
                    }
                }//동적배열의 크기만큼 for문이 반복

                if (q == 0)
                {//배열안에 값이 없는경우 answer를 출력한다
                    Console.WriteLine(answer);
                }
                answer++;
                q = 0;//0으로 다시 초기화를 해야 판독을 제대로 할 수 있다.
            }
            //참고 : https://blog.naver.com/qkrdydrjs7/221938565774



        }
    }
}
