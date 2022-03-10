using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_try_catch
{
    //예외처리 : 개발자가 코드를 통해서 문제를 발생
    //개선의 여지가 있을때
    //내가 만든 코드가 문제가 있을까 확인

    //try ~ catch ~ finally
    //코드를 수정하는 것이 아니고 프로그램이 강제로 죽는 것을 방지
    //문제를 인지하고 추후에 코드 수정 필요
    class Program
    {
        static void Main(string[] args)
        {
            //string str = null;
            //Console.WriteLine(str.ToString());
            //Console.WriteLine("성공 종료!");
            /*
             처리되지 않은 예외: System.NullReferenceException: 개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
            */
            //구체적인 예외보다 Exception을 자주활용하는 이유
                //무슨 예외가 발생할지 알 수 없어요. 다 받아서 처리
            //상위 예외일 수록 뒤에  하위예외를 쓰는 이유 >> 가독성
            //6.try catch 안쓰는게 좋지만 오류 해결 및 프로그램 개선을 위해 사용한다.

            string str = null;
            try
            {
                Console.WriteLine(str.ToString());  
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine(n.Message);
                //1. log 파일에 정보 기록  >> 수정
                //담당자 메일 >> 수정해야한다.
            }
            catch (Exception e) //문제발생시
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
