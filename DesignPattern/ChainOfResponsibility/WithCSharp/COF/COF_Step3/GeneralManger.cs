using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF_Step3
{
    class GeneralManger: Manager
    {
        public GeneralManger(string name) : base(name) { }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine("{0}:{1} 数量 {2} 被批准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine("{0}:{1} 数量 {2} 被批准", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine("{0}:{1} 数量 {2} 再说吧", name, request.RequestContent, request.Number);
            }
        }
    }
}
