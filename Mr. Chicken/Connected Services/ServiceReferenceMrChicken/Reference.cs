﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mr.Chicken.ServiceReferenceMrChicken {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMrChicken.IProgrammService")]
    public interface IProgrammService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyUser", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyUserResponse")]
        IService.EntitiesReturn.UserS GetEmptyUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyUser", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyUserResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.UserS> GetEmptyUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddUser", ReplyAction="http://tempuri.org/IProgrammService/AddUserResponse")]
        void AddUser(IService.EntitiesReturn.UserS user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddUser", ReplyAction="http://tempuri.org/IProgrammService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(IService.EntitiesReturn.UserS user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/IsEmailUnique", ReplyAction="http://tempuri.org/IProgrammService/IsEmailUniqueResponse")]
        bool IsEmailUnique(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/IsEmailUnique", ReplyAction="http://tempuri.org/IProgrammService/IsEmailUniqueResponse")]
        System.Threading.Tasks.Task<bool> IsEmailUniqueAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AccountId", ReplyAction="http://tempuri.org/IProgrammService/AccountIdResponse")]
        int AccountId(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AccountId", ReplyAction="http://tempuri.org/IProgrammService/AccountIdResponse")]
        System.Threading.Tasks.Task<int> AccountIdAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetUsers", ReplyAction="http://tempuri.org/IProgrammService/GetUsersResponse")]
        IService.EntitiesReturn.UserS[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetUsers", ReplyAction="http://tempuri.org/IProgrammService/GetUsersResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.UserS[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/RemoveUserS", ReplyAction="http://tempuri.org/IProgrammService/RemoveUserSResponse")]
        void RemoveUserS(int currentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/RemoveUserS", ReplyAction="http://tempuri.org/IProgrammService/RemoveUserSResponse")]
        System.Threading.Tasks.Task RemoveUserSAsync(int currentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/FindUsersByProp", ReplyAction="http://tempuri.org/IProgrammService/FindUsersByPropResponse")]
        IService.EntitiesReturn.UserS[] FindUsersByProp(string prop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/FindUsersByProp", ReplyAction="http://tempuri.org/IProgrammService/FindUsersByPropResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.UserS[]> FindUsersByPropAsync(string prop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetProductSS", ReplyAction="http://tempuri.org/IProgrammService/GetProductSSResponse")]
        IService.EntitiesReturn.ProductS[] GetProductSS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetProductSS", ReplyAction="http://tempuri.org/IProgrammService/GetProductSSResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.ProductS[]> GetProductSSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateProducts", ReplyAction="http://tempuri.org/IProgrammService/UpdateProductsResponse")]
        void UpdateProducts(IService.EntitiesReturn.ProductS[] productS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateProducts", ReplyAction="http://tempuri.org/IProgrammService/UpdateProductsResponse")]
        System.Threading.Tasks.Task UpdateProductsAsync(IService.EntitiesReturn.ProductS[] productS);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyProduct", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyProductResponse")]
        IService.EntitiesReturn.ProductS GetEmptyProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyProduct", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyProductResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.ProductS> GetEmptyProductAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddProduct", ReplyAction="http://tempuri.org/IProgrammService/AddProductResponse")]
        void AddProduct(IService.EntitiesReturn.ProductS product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddProduct", ReplyAction="http://tempuri.org/IProgrammService/AddProductResponse")]
        System.Threading.Tasks.Task AddProductAsync(IService.EntitiesReturn.ProductS product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/DeleteProduct", ReplyAction="http://tempuri.org/IProgrammService/DeleteProductResponse")]
        void DeleteProduct(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/DeleteProduct", ReplyAction="http://tempuri.org/IProgrammService/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/ChangeProduct", ReplyAction="http://tempuri.org/IProgrammService/ChangeProductResponse")]
        void ChangeProduct(int ID, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/ChangeProduct", ReplyAction="http://tempuri.org/IProgrammService/ChangeProductResponse")]
        System.Threading.Tasks.Task ChangeProductAsync(int ID, string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateUserInfo", ReplyAction="http://tempuri.org/IProgrammService/UpdateUserInfoResponse")]
        void UpdateUserInfo(int userID, IService.EntitiesReturn.UserS user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateUserInfo", ReplyAction="http://tempuri.org/IProgrammService/UpdateUserInfoResponse")]
        System.Threading.Tasks.Task UpdateUserInfoAsync(int userID, IService.EntitiesReturn.UserS user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetUser", ReplyAction="http://tempuri.org/IProgrammService/GetUserResponse")]
        IService.EntitiesReturn.UserS GetUser(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetUser", ReplyAction="http://tempuri.org/IProgrammService/GetUserResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.UserS> GetUserAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmailAcceptS", ReplyAction="http://tempuri.org/IProgrammService/GetEmailAcceptSResponse")]
        IService.EntitiesReturn.EmailAcceptS[] GetEmailAcceptS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmailAcceptS", ReplyAction="http://tempuri.org/IProgrammService/GetEmailAcceptSResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.EmailAcceptS[]> GetEmailAcceptSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmails", ReplyAction="http://tempuri.org/IProgrammService/GetEmailsResponse")]
        string[] GetEmails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmails", ReplyAction="http://tempuri.org/IProgrammService/GetEmailsResponse")]
        System.Threading.Tasks.Task<string[]> GetEmailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetDishesS", ReplyAction="http://tempuri.org/IProgrammService/GetDishesSResponse")]
        IService.EntitiesReturn.DishS[] GetDishesS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetDishesS", ReplyAction="http://tempuri.org/IProgrammService/GetDishesSResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.DishS[]> GetDishesSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyDishS", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyDishSResponse")]
        IService.EntitiesReturn.DishS GetEmptyDishS();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyDishS", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyDishSResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.DishS> GetEmptyDishSAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddDishS", ReplyAction="http://tempuri.org/IProgrammService/AddDishSResponse")]
        void AddDishS(IService.EntitiesReturn.DishS dish);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddDishS", ReplyAction="http://tempuri.org/IProgrammService/AddDishSResponse")]
        System.Threading.Tasks.Task AddDishSAsync(IService.EntitiesReturn.DishS dish);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetDishSById", ReplyAction="http://tempuri.org/IProgrammService/GetDishSByIdResponse")]
        IService.EntitiesReturn.DishS GetDishSById(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetDishSById", ReplyAction="http://tempuri.org/IProgrammService/GetDishSByIdResponse")]
        System.Threading.Tasks.Task<IService.EntitiesReturn.DishS> GetDishSByIdAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateDish", ReplyAction="http://tempuri.org/IProgrammService/UpdateDishResponse")]
        void UpdateDish(IService.EntitiesReturn.DishS dish);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/UpdateDish", ReplyAction="http://tempuri.org/IProgrammService/UpdateDishResponse")]
        System.Threading.Tasks.Task UpdateDishAsync(IService.EntitiesReturn.DishS dish);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/DeleteDishByID", ReplyAction="http://tempuri.org/IProgrammService/DeleteDishByIDResponse")]
        void DeleteDishByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/DeleteDishByID", ReplyAction="http://tempuri.org/IProgrammService/DeleteDishByIDResponse")]
        System.Threading.Tasks.Task DeleteDishByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/StartPromotionBot", ReplyAction="http://tempuri.org/IProgrammService/StartPromotionBotResponse")]
        void StartPromotionBot(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/StartPromotionBot", ReplyAction="http://tempuri.org/IProgrammService/StartPromotionBotResponse")]
        System.Threading.Tasks.Task StartPromotionBotAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddIntermidiatef", ReplyAction="http://tempuri.org/IProgrammService/AddIntermidiatefResponse")]
        void AddIntermidiatef(IService.EntitiesReturn.IntermediateS[] list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddIntermidiatef", ReplyAction="http://tempuri.org/IProgrammService/AddIntermidiatefResponse")]
        System.Threading.Tasks.Task AddIntermidiatefAsync(IService.EntitiesReturn.IntermediateS[] list);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProgrammServiceChannel : Mr.Chicken.ServiceReferenceMrChicken.IProgrammService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProgrammServiceClient : System.ServiceModel.ClientBase<Mr.Chicken.ServiceReferenceMrChicken.IProgrammService>, Mr.Chicken.ServiceReferenceMrChicken.IProgrammService {
        
        public ProgrammServiceClient() {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IService.EntitiesReturn.UserS GetEmptyUser() {
            return base.Channel.GetEmptyUser();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.UserS> GetEmptyUserAsync() {
            return base.Channel.GetEmptyUserAsync();
        }
        
        public void AddUser(IService.EntitiesReturn.UserS user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(IService.EntitiesReturn.UserS user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public bool IsEmailUnique(string email) {
            return base.Channel.IsEmailUnique(email);
        }
        
        public System.Threading.Tasks.Task<bool> IsEmailUniqueAsync(string email) {
            return base.Channel.IsEmailUniqueAsync(email);
        }
        
        public int AccountId(string login, string password) {
            return base.Channel.AccountId(login, password);
        }
        
        public System.Threading.Tasks.Task<int> AccountIdAsync(string login, string password) {
            return base.Channel.AccountIdAsync(login, password);
        }
        
        public IService.EntitiesReturn.UserS[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.UserS[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public void RemoveUserS(int currentID) {
            base.Channel.RemoveUserS(currentID);
        }
        
        public System.Threading.Tasks.Task RemoveUserSAsync(int currentID) {
            return base.Channel.RemoveUserSAsync(currentID);
        }
        
        public IService.EntitiesReturn.UserS[] FindUsersByProp(string prop) {
            return base.Channel.FindUsersByProp(prop);
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.UserS[]> FindUsersByPropAsync(string prop) {
            return base.Channel.FindUsersByPropAsync(prop);
        }
        
        public IService.EntitiesReturn.ProductS[] GetProductSS() {
            return base.Channel.GetProductSS();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.ProductS[]> GetProductSSAsync() {
            return base.Channel.GetProductSSAsync();
        }
        
        public void UpdateProducts(IService.EntitiesReturn.ProductS[] productS) {
            base.Channel.UpdateProducts(productS);
        }
        
        public System.Threading.Tasks.Task UpdateProductsAsync(IService.EntitiesReturn.ProductS[] productS) {
            return base.Channel.UpdateProductsAsync(productS);
        }
        
        public IService.EntitiesReturn.ProductS GetEmptyProduct() {
            return base.Channel.GetEmptyProduct();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.ProductS> GetEmptyProductAsync() {
            return base.Channel.GetEmptyProductAsync();
        }
        
        public void AddProduct(IService.EntitiesReturn.ProductS product) {
            base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task AddProductAsync(IService.EntitiesReturn.ProductS product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public void DeleteProduct(int ID) {
            base.Channel.DeleteProduct(ID);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int ID) {
            return base.Channel.DeleteProductAsync(ID);
        }
        
        public void ChangeProduct(int ID, string Name) {
            base.Channel.ChangeProduct(ID, Name);
        }
        
        public System.Threading.Tasks.Task ChangeProductAsync(int ID, string Name) {
            return base.Channel.ChangeProductAsync(ID, Name);
        }
        
        public void UpdateUserInfo(int userID, IService.EntitiesReturn.UserS user) {
            base.Channel.UpdateUserInfo(userID, user);
        }
        
        public System.Threading.Tasks.Task UpdateUserInfoAsync(int userID, IService.EntitiesReturn.UserS user) {
            return base.Channel.UpdateUserInfoAsync(userID, user);
        }
        
        public IService.EntitiesReturn.UserS GetUser(int ID) {
            return base.Channel.GetUser(ID);
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.UserS> GetUserAsync(int ID) {
            return base.Channel.GetUserAsync(ID);
        }
        
        public IService.EntitiesReturn.EmailAcceptS[] GetEmailAcceptS() {
            return base.Channel.GetEmailAcceptS();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.EmailAcceptS[]> GetEmailAcceptSAsync() {
            return base.Channel.GetEmailAcceptSAsync();
        }
        
        public string[] GetEmails() {
            return base.Channel.GetEmails();
        }
        
        public System.Threading.Tasks.Task<string[]> GetEmailsAsync() {
            return base.Channel.GetEmailsAsync();
        }
        
        public IService.EntitiesReturn.DishS[] GetDishesS() {
            return base.Channel.GetDishesS();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.DishS[]> GetDishesSAsync() {
            return base.Channel.GetDishesSAsync();
        }
        
        public IService.EntitiesReturn.DishS GetEmptyDishS() {
            return base.Channel.GetEmptyDishS();
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.DishS> GetEmptyDishSAsync() {
            return base.Channel.GetEmptyDishSAsync();
        }
        
        public void AddDishS(IService.EntitiesReturn.DishS dish) {
            base.Channel.AddDishS(dish);
        }
        
        public System.Threading.Tasks.Task AddDishSAsync(IService.EntitiesReturn.DishS dish) {
            return base.Channel.AddDishSAsync(dish);
        }
        
        public IService.EntitiesReturn.DishS GetDishSById(int ID) {
            return base.Channel.GetDishSById(ID);
        }
        
        public System.Threading.Tasks.Task<IService.EntitiesReturn.DishS> GetDishSByIdAsync(int ID) {
            return base.Channel.GetDishSByIdAsync(ID);
        }
        
        public void UpdateDish(IService.EntitiesReturn.DishS dish) {
            base.Channel.UpdateDish(dish);
        }
        
        public System.Threading.Tasks.Task UpdateDishAsync(IService.EntitiesReturn.DishS dish) {
            return base.Channel.UpdateDishAsync(dish);
        }
        
        public void DeleteDishByID(int ID) {
            base.Channel.DeleteDishByID(ID);
        }
        
        public System.Threading.Tasks.Task DeleteDishByIDAsync(int ID) {
            return base.Channel.DeleteDishByIDAsync(ID);
        }
        
        public void StartPromotionBot(string message) {
            base.Channel.StartPromotionBot(message);
        }
        
        public System.Threading.Tasks.Task StartPromotionBotAsync(string message) {
            return base.Channel.StartPromotionBotAsync(message);
        }
        
        public void AddIntermidiatef(IService.EntitiesReturn.IntermediateS[] list) {
            base.Channel.AddIntermidiatef(list);
        }
        
        public System.Threading.Tasks.Task AddIntermidiatefAsync(IService.EntitiesReturn.IntermediateS[] list) {
            return base.Channel.AddIntermidiatefAsync(list);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMrChicken.IServiceBot", CallbackContract=typeof(Mr.Chicken.ServiceReferenceMrChicken.IServiceBotCallback))]
    public interface IServiceBot {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/GetUsersTelegramID", ReplyAction="http://tempuri.org/IServiceBot/GetUsersTelegramIDResponse")]
        string[] GetUsersTelegramID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/GetUsersTelegramID", ReplyAction="http://tempuri.org/IServiceBot/GetUsersTelegramIDResponse")]
        System.Threading.Tasks.Task<string[]> GetUsersTelegramIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceBot/GetStatusMsg")]
        void GetStatusMsg(string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceBot/GetStatusMsg")]
        System.Threading.Tasks.Task GetStatusMsgAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StartBot", ReplyAction="http://tempuri.org/IServiceBot/StartBotResponse")]
        void StartBot();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StartBot", ReplyAction="http://tempuri.org/IServiceBot/StartBotResponse")]
        System.Threading.Tasks.Task StartBotAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StopBot", ReplyAction="http://tempuri.org/IServiceBot/StopBotResponse")]
        void StopBot();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StopBot", ReplyAction="http://tempuri.org/IServiceBot/StopBotResponse")]
        System.Threading.Tasks.Task StopBotAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StartReceiving", ReplyAction="http://tempuri.org/IServiceBot/StartReceivingResponse")]
        void StartReceiving();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StartReceiving", ReplyAction="http://tempuri.org/IServiceBot/StartReceivingResponse")]
        System.Threading.Tasks.Task StartReceivingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StopReceiving", ReplyAction="http://tempuri.org/IServiceBot/StopReceivingResponse")]
        void StopReceiving();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBot/StopReceiving", ReplyAction="http://tempuri.org/IServiceBot/StopReceivingResponse")]
        System.Threading.Tasks.Task StopReceivingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBotCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceBot/AddMessage")]
        void AddMessage(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBotChannel : Mr.Chicken.ServiceReferenceMrChicken.IServiceBot, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBotClient : System.ServiceModel.DuplexClientBase<Mr.Chicken.ServiceReferenceMrChicken.IServiceBot>, Mr.Chicken.ServiceReferenceMrChicken.IServiceBot {
        
        public ServiceBotClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceBotClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceBotClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBotClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBotClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string[] GetUsersTelegramID() {
            return base.Channel.GetUsersTelegramID();
        }
        
        public System.Threading.Tasks.Task<string[]> GetUsersTelegramIDAsync() {
            return base.Channel.GetUsersTelegramIDAsync();
        }
        
        public void GetStatusMsg(string msg) {
            base.Channel.GetStatusMsg(msg);
        }
        
        public System.Threading.Tasks.Task GetStatusMsgAsync(string msg) {
            return base.Channel.GetStatusMsgAsync(msg);
        }
        
        public void StartBot() {
            base.Channel.StartBot();
        }
        
        public System.Threading.Tasks.Task StartBotAsync() {
            return base.Channel.StartBotAsync();
        }
        
        public void StopBot() {
            base.Channel.StopBot();
        }
        
        public System.Threading.Tasks.Task StopBotAsync() {
            return base.Channel.StopBotAsync();
        }
        
        public void StartReceiving() {
            base.Channel.StartReceiving();
        }
        
        public System.Threading.Tasks.Task StartReceivingAsync() {
            return base.Channel.StartReceivingAsync();
        }
        
        public void StopReceiving() {
            base.Channel.StopReceiving();
        }
        
        public System.Threading.Tasks.Task StopReceivingAsync() {
            return base.Channel.StopReceivingAsync();
        }
    }
}
