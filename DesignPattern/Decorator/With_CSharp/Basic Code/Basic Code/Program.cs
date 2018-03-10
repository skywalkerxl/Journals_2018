using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompnent c = new ConcreteCompnent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.Read();
        }

        // 首先定义 Component 类
        abstract class Component
        {
            // 用于子类重写的抽象类
            public abstract void Operation();
        }

        // 定义 ConcreteComponent 类
        class ConcreteCompnent : Component
        {
            public override void Operation()
            {
                Console.WriteLine("具体对象的操作");
            }
        }

        // 定义 Decorator 类
        abstract class Decorator : Component
        {
            // ???
            protected Component component;

            // 设置 Component 
            public void SetComponent(Component component)
            {
                this.component = component;
            }

            // 重写 Operation
            public override void Operation()
            {
                if (component != null)
                {
                    component.Operation();
                }
            }
        }

        // 定义 ConcreteDecoratorA 类
        class ConcreteDecoratorA : Decorator
        {
            private string addedState;

            public override void Operation()
            {
                base.Operation();
                addedState = "New State";
                Console.WriteLine("具体装饰对象A的操作");
            }
        }

        // 定义 ComcreteDecoratorB 类
        class ConcreteDecoratorB : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                AddedBehavior();
                Console.WriteLine("具体装饰对象B的操作");
            }

            private void AddedBehavior()
            {

            }
        }
    }
}
