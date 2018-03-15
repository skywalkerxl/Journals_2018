using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF_RF
{
    class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}
