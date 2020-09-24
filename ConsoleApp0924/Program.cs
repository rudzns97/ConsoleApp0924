using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
    //예외처리
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BBB();
                string eee = Console.ReadLine();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private static void BBB()
        {
            AAA();
        }
        static void AAA()
        {

                int[] arr = new int[5] { 1, 2, 0, 4, 5 };
                Console.WriteLine("몇번째 배열의 값으로 계산할까요?");
                int idx = int.Parse(Console.ReadLine());

                if (idx < 0 || idx > 4)
                {
                    //Console.WriteLine("0~4 범위안의 수를 입력하세요.");
                    throw new Exception("0~4 범위안의 수를 입력하세요.");
                }

                int p = arr[idx];
                int k = 10 / p;

                Console.WriteLine(k);
            }
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0으로 나눌 수 없습니다.");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("0~4 범위안의 수를 입력하세요.");
            //}
            //catch (Exception err)
            //{
            //    //Console.WriteLine("처리중 오류가 발생했습니다. 다시한번 시도");
            //    throw err;
            //}
            
        }
    }

