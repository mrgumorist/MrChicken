using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.Chicken.Controllers
{
    //public class CallbackController: IService.IServiceBotCallback
    //{
    //    public event EventHandler PingReplyReceived;

    //    private SrvServiceClient _innerClient;

    //    private SrvServiceCallbackProxy()
    //    {
    //        var instanceContext = new System.ServiceModel.InstanceContext(this);
    //        _innerClient = new SrvService.SrvServiceClient(instanceContext);

    //    }

    //    private static SrvServiceCallbackProxy _instance;
    //    public static SrvServiceCallbackProxy Instance => _instance ?? (_instance = new SrvServiceCallbackProxy());


    //    public void PingReply(string reply)
    //    {
    //        this.PingReplyReceived?.Invoke(reply, EventArgs.Empty);
    //    }

    //    public void AddMessage(string msg)
    //    {
    //        string message = msg;
    //    }
    //}
}
