using IService.EntitiesReturn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    [ServiceContract(CallbackContract = typeof(IServiceBotCallback))]
    public interface IServiceBot
    {
        [OperationContract]
        List<string> GetUsersTelegramID();
        [OperationContract(IsOneWay = true)]
        void GetStatusMsg(string msg);
        [OperationContract]
        void StartBot();
        [OperationContract]
        void StopBot();
        [OperationContract]
        void StartReceiving();
        [OperationContract]
        void StopReceiving();
        
        
    }

    public interface IServiceBotCallback
    {
        [OperationContract(IsOneWay = true)]
        void AddMessage(string message);
    }
}
