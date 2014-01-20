using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealTimeLogging
{
    public static class HubCaller
    {
        public static void Invoke<THub>(Action<IHubContext> action) where THub : IHub
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<THub>();

            action.Invoke(context);
        }
    }
}