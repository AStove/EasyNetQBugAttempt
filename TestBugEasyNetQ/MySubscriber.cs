using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using EasyNetQ.NonGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBugEasyNetQ
{
    public class MySubscriber : AutoSubscriber
    {
        public MySubscriber(IBus bus) : base(bus, "asdf")
        {
            bus.Subscribe(typeof(string), "asdf", (o) => { });
        }
    }
}
