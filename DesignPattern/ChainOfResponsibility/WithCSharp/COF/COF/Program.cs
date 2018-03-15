using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Request
    {
        // 申请类别
        private string requestType;
        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }

        // 申请内容
        private string requestContent;
        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }

        // 数量
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }

    /// <summary>
    /// 管理者
    /// </summary>
    class Manager
    {
        protected string name;
        public Manager(string name)
        {
            this.name = name;
        }

        public void GetResult(string managaerLevel, Request request)
        {

        }
    }
}
