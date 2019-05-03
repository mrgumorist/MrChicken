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
        List<ProductS> GetProductSS();
        [OperationContract]
        void UpdateProducts(List<ProductS> productS);
        [OperationContract]
        Product GetEmptyProduct();
        [OperationContract]
        void AddProduct(Product product);
        [OperationContract]
        void DeleteProduct(int ID);
        [OperationContract]
        void ChangeProduct(int ID, string Name);
    }
}
