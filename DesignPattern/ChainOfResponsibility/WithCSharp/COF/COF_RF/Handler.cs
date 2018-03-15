using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COF_RF
{
    abstract class Handler
    {
        protected Handler successor;

        /// <summary>
        /// 设置继承者
        /// </summary>
        /// <param name="successor"></param>
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// 处理请求的抽象方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandlerRequest(int request);
    }
}
