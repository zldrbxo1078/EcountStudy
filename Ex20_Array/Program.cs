using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열은 객체다
            //1. new를 통해 생성
            //2. heap메모리에 생성
            //3. 고정배열(정적배열) : 배열의 크기가 결정되면 변경 불가

            int[] arr = new int[5]; //초기화 없을 시 default 값으로 초기화
            Console.WriteLine(arr[0]);
            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr2[0]);
            int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr4 = { 100, 200, 300, 400, 500 };   //컴파일러가 new int를 자동으로 설정

            //for(int i=0;i < 6; i++)
            //{
            //    Console.WriteLine(arr4[i]);
            //}

            Console.WriteLine(arr4.Length);
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            Console.WriteLine("Foreach");
            foreach (var item in arr4)    //나열된 자료를 순차적으로 추출해주는 논리 >> 반복횟수를 생각하지 않아도 된다.
            {
                Console.WriteLine("arr4 : {0}", item);
            }

            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; //주소값 할당! >> ar 와 ar2는 배열을 공유
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.WriteLine("ar : {0}", ar[i]);
                Console.WriteLine("ar : {0}", ar2[i]);

            }
            string[] strarr = new string[] { "가", "나", "가나다", "마" };

            int[] varray = new int[] { 12, 56, 45, 90, 56, 10 };
            Console.WriteLine("인덱스 값 : {0}", Array.IndexOf(varray, 45)); //인덱스값을 직접 지정
            Console.WriteLine("인덱스 값 : {0}", Array.LastIndexOf(varray, 56)); //마지막으로 나오는 해당값의 인덱스 값

            Array.Sort(varray); //자동정렬 초급자 검지검지.. 과제 시 sort 함수 쓰면 빵점
            Console.WriteLine("자동 정렬 Asc");
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray[{i}] : {varray[i]}");
            }

            Array.Reverse(varray); //자동정렬 초급자 검지검지.. 과제 시 sort 함수 쓰면 빵점
            Console.WriteLine("자동 정렬 Asc");
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray[{i}] : {varray[i]}");
            }

            //초급 정렬 코드 직접 구현 (swap 방식, bubble sort)
            Console.WriteLine("Clear");
            Array.Clear(varray, 2, 3);
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine($"varray[i] :{varray[i]}");
            }

            int[] a = new int[] { 45, 12, 88, 97, 10 };
            int[] b = new int[5];
            Array.Copy(a, b, 3);    //3개까지만
            foreach (int item in b)
            {
                Console.WriteLine($"{item}");
            }

            //2차원 배열
            int[,] arr5 = new int[3, 2];
            arr5[0, 0] = 100;
            Console.WriteLine("arr5 : {0}", arr5[0, 0]);

            int[,] arr6 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //arr.GetLength(0) 행의 개수 - 뒤의 인수는 차원
            //arr.GetLength(1) 열의 개수
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.WriteLine(arr6[i, j]);
                }
            }


        }
    }
}
