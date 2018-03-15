using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF_RF
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);  // 设置h1职责链的下家为h2
            h2.SetSuccessor(h3);  // 设置h2职责链的下家为h3

            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }

            Console.ReadKey();
        }
    }
}
