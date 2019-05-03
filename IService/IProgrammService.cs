using IService.Entities;
using IService.EntitiesReturn;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        UserS GetEmptyUser();
        [OperationContract]
        void AddUser(UserS user);
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
        List<ProductS> GetProductSS();
        [OperationContract]
        void UpdateProducts(List<ProductS> productS);
        [OperationContract]
        ProductS GetEmptyProduct();
        [OperationContract]
        void AddProduct(ProductS product);
        [OperationContract]
        void DeleteProduct(int ID);
        [OperationContract]
        void ChangeProduct(int ID, string Name);
        [OperationContract]
        void UpdateUserInfo(int userID, User user);
        [OperationContract]
        UserS GetUser(int ID);

    }
}
