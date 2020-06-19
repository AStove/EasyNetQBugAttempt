using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBugEasyNetQ
{
    public class MySubscriber : AutoSubscriber
    {
        public MySubscriber(IBus bus) : base(bus, "qsdf")
        {
            bus.PubSub.Subscribe<string>("asdf", (o) => { });
        }
    }
}
