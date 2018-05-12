using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace _20180512Lab02_從無到有的建立SignalR
{
    [HubName("IM")]
    public class MyHub1 : Hub
    {
        public void Hello()
        {
            Clients.All.hello("登入成功!!");
        }

        public void Send(string msg)
        {
            Clients.All.receive("get msg: " + msg);
        }
    }
}