using System;
using System.Threading;
//Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace Timer
{
    class Timer
    {
        public delegate void MethodDelegate();

        //Properties
        public uint Delay { get; set; }
        public MethodDelegate MethodProp { get; set; }

        //Constructor
        public Timer(uint delay, MethodDelegate executeMethod)
        {
            this.Delay = delay;
            this.MethodProp = executeMethod;

            Thread newThread = new Thread(() =>
                { 
                    while (true)
                    {
                        this.MethodProp();
                        Thread.Sleep((int)this.Delay);
                    }
                });
            newThread.Start();
        }

        public static void TestMethodOne()
        {
            Console.WriteLine("Testing timer with TestMethodOne at: {0}", DateTime.Now);
        }

        public static void TestMethodTwo()
        {
            Console.WriteLine("Testing timer with with TestMethodTwo at: {0}", DateTime.Now);
        }
    }
}
