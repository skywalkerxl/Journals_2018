using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF_RF
{
    class ConcreteHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            // 0到10，处理此请求
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} 处理请求 {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}
