using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //再帰実行
            exec();
        }

        static void exec()
        {
            // int nは、キーボードからの入力
            var input = Console.ReadLine();
            if (input != null)
            {
                int test;
                var n = int.Parse(input);  // ユーザーの入力した整数を読み込む
                var c = new Calculator();
                c.calc(n, 0);
                Console.WriteLine(c.count);
                exec();
            }
            Console.ReadLine();
        }
    }

    class Calculator
    {
        public int count = 0;
        public void calc(int n, int p)
        {
            count++;
            if (p > n) return;
            for (int i = 0; i < n; i++)
            {
                calc(n, p + 1);
            }
        }
    }

}
