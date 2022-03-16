using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Array_Param
{
    class Lotto
    {
        private int[] numbers;
        private Random random;

        public Lotto()  //member field 초기화가 목적인 생성자에 처리...
        {
            numbers = new int[6];
        }
        public void getREadLottoNumbers()
        {

        }
        public void displayLottoNumbers()
        {

        }

        //추가적인 함수 구현
    }
}
/*
    static void Main(){
        Lotto lotto = new Lotto();
        lotto.getReadLottoNumbers();
        lotto.displayLottoNumbers();
 */