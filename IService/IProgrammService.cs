using IService.EntitiesReturn;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    [ServiceContract]
    public interface IProgrammService
    {
        [OperationContract]
        string Msg(string msg);
        [OperationContract]
        User GetEmptyUser();
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        bool IsEmailUnique(string email);
        [OperationContract]
        int AccountId(string login, string password);
        [OperationContract]
        List<UserS> GetUsers();
        [OperationContract]
        void RemoveUserS(int currentID);
        [OperationContract]
        List<UserS> FindUsersByProp(string prop);
        [OperationContract]
        void UpdateUserInfo(int userID, User user);
        [OperationContract]
        User GetUser(int ID);

    }
}
