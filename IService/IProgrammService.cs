﻿using IService.Entities;
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
        //[OperationContract]
        //string BotInfo();
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
        void UpdateUserInfo(int userID, UserS user);
        [OperationContract]
        UserS GetUser(int ID);
        [OperationContract]
        List<EmailAcceptS> GetEmailAcceptS();
        [OperationContract]
        List<string> GetEmails();
        [OperationContract]
        List<DishS> GetDishesS();
        [OperationContract]
        DishS GetEmptyDishS();
        [OperationContract]
        void AddDishS(DishS dish);
        [OperationContract]
        DishS GetDishSById(int ID);
        [OperationContract]
        void UpdateDish(DishS dish);
        [OperationContract]
        void DeleteDishByID(int ID);
        [OperationContract]
        void StartPromotionBot(string message);        
        [OperationContract]
        void AddIntermidiatef(IntermediateS[] list);
        [OperationContract]
        void SetTelegramID(int userId,string id);
        [OperationContract]
        void AddUserProducts(UserProductsS item);
        [OperationContract]
        List<UserProductsS> GetUserProducts(int Userid);
        [OperationContract]
        void DeleteProductByName(string prodName);
        [OperationContract]
        List<DishS> GetUseAvailableRecept(int UserId);
        [OperationContract]
        List<IntermediateS> GetRecipeProdByName(int id);
        [OperationContract]
        void DeleteProductIntermediateByID(string prodName);
        [OperationContract]
        string GetRecipesBot(List<DishS> recipes);





    }
}
