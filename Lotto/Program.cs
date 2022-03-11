using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Lotto
    {
        int[] lotto_num;
        Random random;

        public Lotto()
        {
            lotto_num = new int[6]; //배열 초기화
            random = new Random(); //난수 생성 초기화
        }
        public void setNumber()
        {
            int a;  //난수 담을 변수 생성
            for (int i = 0; i < lotto_num.Length; i++)
            {
                a = random.Next(1, 46);
                if (dupCheck(i, a)) //중복 함수 결과가 참이면
                {
                    lotto_num[i] = a;
                }
                else
                {
                    i--;
                }
            }
        }
        private bool dupCheck(int count, int val)
        {
            for (int i = 0; i < count; i++)
            {
                if (val == lotto_num[i])    //지금까지의 배열 중 일치하는 값이 있으면 false
                {
                    return false;
                }
            }
            return true; //없으면 참 
        }
        public void displayLottoNumbers()
        {
            sortNum();
            Console.WriteLine("생성된 로또 번호입니다.");
            for (int i = 0; i < lotto_num.Length; i++)
            {
                Console.Write($"{lotto_num[i]} ");
            }
            Console.WriteLine();
        }

        private void sortNum()
        {
            int temp = 0;
            for (int i = 0; i < lotto_num.Length; i++)
            {
                for (int j = 0; j < lotto_num.Length; j++)
                {
                    if (lotto_num[i] < lotto_num[j])
                    {
                        temp = lotto_num[i];
                        lotto_num[i] = lotto_num[j];
                        lotto_num[j] = temp;

                    }

                }

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Lotto lotto = new Lotto();
            lotto.setNumber();
            lotto.displayLottoNumbers();
        }
    }
}
