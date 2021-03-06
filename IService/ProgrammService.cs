﻿using IService.Entities;
using IService.EntitiesReturn;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using IService.MyBott;
using System.IO;
using System.ServiceModel;

namespace IService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ProgrammService : IProgrammService, IServiceBot
    {
        private static MyBot myBotCLient = new MyBot("826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE");
        Context context = new Context();
        //List<UserS> users;
        List<OperationContext> users = new List<OperationContext>();
        public ProgrammService()
        {
            if (!myBotCLient.IsStarted)
                myBotCLient.StartBot();
            myBotCLient.GetStatusMessage += this.GetStatusMsg;
        }
        public string BotInfo()
        {
            string msg = "Bot ID: " + myBotCLient.ID + " Bot name: " + myBotCLient.Name;

            return msg;
        }
        public UserS GetEmptyUser()
        {
            return new UserS();
        }
        public void AddUser(UserS user)
        {
            context.users.Add(new User() { Name = user.Name, Login = user.Login, DateOfBirth = user.DateOfBirth, DateOfRegister = user.DateOfRegister, Email = user.Email, ISConfirmed = user.ISConfirmed, Password = user.Password, Surname = user.Surname, TelegramID = user.TelegramID, DoesWantRecomendations = user.DoesWantRecomendations });
            context.SaveChangesAsync();
        }
        public bool IsEmailUnique(string email)
        {
            foreach (var item in context.users)
            {
                if (item.Email == email)
                {
                    return false;
                }
            }
            return true;
        }
        public int AccountId(string login, string password)
        {
            int id = -1;
            foreach (var item in context.users)
            {
                if (item.Login == login && item.Password == password)
                {
                    id = item.ID;
                    break;
                }
            }
            return id;
        }
        public UserS GetUser(int ID)
        {
            var users = context.users.Select(t => new UserS()
            {
                ID = t.ID,
                Name = t.Name,
                Surname = t.Surname,
                Login = t.Login,
                Password = t.Password,
                TelegramID = t.TelegramID,
                Email = t.Email,
                ISConfirmed = t.ISConfirmed,
                DateOfBirth = t.DateOfBirth,
                DateOfRegister = t.DateOfRegister,
                DoesWantRecomendations = t.DoesWantRecomendations
            }).ToList();
            return users.Where(t => t.ID == ID).FirstOrDefault();
        }

        public List<UserS> GetUsers()
        {

            var users1 = context.users.ToList();
            var users = context.users.Select(t => new UserS()
            {
                ID = t.ID,
                Name = t.Name,
                Surname = t.Surname,
                Login = t.Login,
                Password = t.Password,
                TelegramID = t.TelegramID,
                Email = t.Email,
                ISConfirmed = t.ISConfirmed,
                DateOfBirth = t.DateOfBirth,
                DateOfRegister = t.DateOfRegister,
                DoesWantRecomendations = t.DoesWantRecomendations
            }).ToList();
            return users;
        }
        public void RemoveUserS(int currentID)
        {
            context.users.Remove(context.users.Where(u => u.ID == currentID).FirstOrDefault());
            context.SaveChanges();
        }
        public List<UserS> FindUsersByProp(string prop)
        {
            var users = context.users.Where(t => t.ID.ToString().Contains(prop) ||
            t.Name.Contains(prop) || t.Email.Contains(prop) || t.Surname.Contains(prop) ||
            t.Password.Contains(prop) || t.TelegramID.Contains(prop)).Select(t => new UserS()
            {
                ID = t.ID,
                Name = t.Name,
                Surname = t.Surname,
                Login = t.Login,
                Password = t.Password,
                TelegramID = t.TelegramID,
                Email = t.Email,
                ISConfirmed = t.ISConfirmed,
                DateOfBirth = t.DateOfBirth,
                DateOfRegister = t.DateOfRegister,
                DoesWantRecomendations = t.DoesWantRecomendations
            }).ToList();
            return users;
        }
        public List<ProductS> GetProductSS()
        {
            var products = context.products.Select(t => new ProductS() { ID = t.ID, Name = t.Name }).ToList();
            return products;
        }
        //DELETE THIS method
        public void UpdateProducts(List<ProductS> productS)
        {
            //foreach (var item in productS)
            //{

            //    context.product
            //}
        }
        public ProductS GetEmptyProduct()
        {
            return new ProductS();
        }
        public void AddProduct(ProductS product)
        {
            context.products.Add(new Product() { Name = product.Name });
            context.SaveChanges();
        }
        //TO DO
        public void DeleteProduct(int ID)
        {
            context.products.Remove(context.products.Where(t => t.ID == ID).First());
            context.SaveChanges();
        }
        public void ChangeProduct(int ID, string Name)
        {
            context.products.Where(t => t.ID == ID).First().Name = Name;
            context.SaveChanges();
        }
        public void UpdateUserInfo(int userID, UserS user)
        {
            var User = context.users.Where(u => u.ID == userID).FirstOrDefault();

            User.DateOfBirth = user.DateOfBirth;
            User.Email = user.Email;
            User.Login = user.Login;
            User.Password = user.Password;
            User.Surname = user.Surname;
            User.Name = user.Name;
            User.TelegramID = user.TelegramID;
            context.SaveChanges();
        }

        public List<EmailAcceptS> GetEmailAcceptS()
        {
            return (context.emailAccepts.Select(t => new EmailAcceptS() { ID = t.ID, VerificationCode = t.VerificationCode, UserID = t.UserID }).ToList());
        }
        public List<string> GetEmails()
        {
            List<string> email = new List<string>();
            foreach (var item in context.users)
            {
                if (item.ISConfirmed == true) // чи підтверджений емайл
                {
                    email.Add(item.Email);
                }
            }
            return email;
        }
        public List<DishS> GetDishesS()
        {
            var list = new List<DishS>();
            foreach (var item in context.dishes)
            {
                var dish = new DishS();
                dish.ID = item.ID;
                //dish.Image = File.ReadAllBytes($@"Images\{dish.ID}.jpg");
                dish.Name = item.Name;
                dish.Recept = item.Recept;
                dish.TypeID = item.TypeID;
                dish.LittleDescription = item.LittleDescription;
                list.Add(dish);
            }
            return list;

        }
        public DishS GetEmptyDishS()
        {
            return new DishS();
        }
        public void AddDishS(DishS dish)
        {
            context.dishes.Add(new Dish() { ID = dish.ID, /*Image = dish.Image,*/ LittleDescription = dish.LittleDescription, Name = dish.Name, Recept = dish.Recept, TypeID = dish.TypeID });
            //Helperr.ByteToImage(dish.Image).Save($@"Images\{dish.ID}.jpg");
            context.SaveChanges();
        }
        public DishS GetDishSById(int ID)
        {
            var item = context.dishes.Select(t => new DishS() { ID = t.ID, /*Image = t.Image,*/ LittleDescription = t.LittleDescription, Name = t.Name, Recept = t.Recept, TypeID = t.TypeID }).ToList().Where(t => t.ID == ID).First();
            //item.Image = File.ReadAllBytes($@"Images\{item.ID}.jpg");
            return item;
        }
        public void UpdateDish(DishS dish)
        {
            context.dishes.Where(t => t.ID == dish.ID).First().Name = dish.Name;
            /* context.dishes.Where(t => t.ID == dish.ID).First().Image = dish.Image;*/
            context.dishes.Where(t => t.ID == dish.ID).First().LittleDescription = dish.LittleDescription;
            context.dishes.Where(t => t.ID == dish.ID).First().Recept = dish.Recept;
            context.dishes.Where(t => t.ID == dish.ID).First().TypeID = dish.TypeID;
            File.Delete($@"Images\{ context.dishes.Where(t => t.ID == dish.ID).First().ID}.jpg");
            //Helperr.ByteToImage(dish.Image).Save($@"Images\{dish.ID}.jpg");
            context.SaveChanges();
        }
        public void DeleteDishByID(int ID)
        {
            context.dishes.Remove(context.dishes.Where(t => t.ID == ID).First());
            File.Delete($@"Images\{ context.dishes.Where(t => t.ID == ID).First().ID}.jpg");
            context.SaveChanges();
        }
        public void StartBot()
        {
            if (!myBotCLient.IsStarted)
                myBotCLient.StartBot();
        }
        public void StopBot()
        {
            if (myBotCLient.IsStarted)
                myBotCLient.Stop();
        }
        public void GetStatusMsg(string msg)
        {
            try
            {
                foreach (var item in users)
                {
                    item.GetCallbackChannel<IServiceBotCallback>().AddMessage(msg);
                }

            }
            catch (Exception)
            {
            }

        }
        public List<string> GetUsersTelegramID()
        {

            List<string> TelegramId = new List<string>();
            foreach (var item in context.users)
            {
                if (item.TelegramID != "-")
                {
                    TelegramId.Add(item.TelegramID);
                }

            }
            return TelegramId;

        }
        public void AddIntermidiatef(IntermediateS[] list)
        {

            foreach (var item in list)
            {
                Intermediate intermediate = new Intermediate();
                intermediate.ProductID = item.ProductID;
                intermediate.DishID = item.DishID;
                context.intermediate.Add(intermediate);
            }

            context.SaveChanges();
        }

        public void StartPromotionBot(string message)
        {
            List<string> TelegramID = GetUsersTelegramID();

            foreach (var item in TelegramID)
            {
                myBotCLient.SendMsgToUser(item, message);
            }
        }

        public void StartReceiving()
        {
            if (!users.Any(x => x == OperationContext.Current))
                users.Add(OperationContext.Current);
        }

        public void StopReceiving()
        {
            users.Remove(users.FirstOrDefault(t => t.SessionId == OperationContext.Current.SessionId));
        }

        public void SetTelegramID(int userId, string Telegramid)
        {
            var user = context.users.FirstOrDefault(u => u.ID == userId);
            user.TelegramID = Telegramid;
            context.SaveChanges();
        }

        public void AddUserProducts(UserProductsS item)
        {
            {
                UserProducts userProducts = new UserProducts();
                userProducts.ProductID = item.ProductID;
                userProducts.UserID = item.UserID;
                context.userProducts.Add(userProducts);
                context.SaveChanges();
            }
        }



        public List<UserProductsS> GetUserProducts(int Userid)
        {
            var list = new List<UserProductsS>();
            foreach (var item in context.userProducts)
            {
                if (item.UserID == Userid)
                {
                    var userProd = new UserProductsS();
                    userProd.ID = item.ID;
                    userProd.UserID = item.UserID;
                    userProd.ProductID = item.ProductID;

                    list.Add(userProd);
                }
            }
            return list;
        }
        public List<IntermediateS> GetRecipeProdByName(int ID)
        {
            var list = new List<IntermediateS>();
            foreach (var item in context.intermediate)
            {
                if (item.DishID == ID)
                {
                    var intermediateRec = new IntermediateS();
                    intermediateRec.ID = item.ID;
                    intermediateRec.DishID = item.DishID;
                    intermediateRec.ProductID = item.ProductID;

                    list.Add(intermediateRec);
                }
            }
            return list;

        }
        public void DeleteProductIntermediateByID(string prodName)
        {
            context.intermediate.Remove(context.intermediate.FirstOrDefault(u => u.ProductID == context.products
            .FirstOrDefault(p => p.Name == prodName).ID));
            context.SaveChanges();
        }
        public void DeleteProductByName(string prodName)
        {
            context.userProducts.Remove(context.userProducts.FirstOrDefault(u => u.ProductID == context.products
            .FirstOrDefault(p => p.Name == prodName).ID));
            context.SaveChanges();
        }
        public List<DishS> GetUseAvailableRecept(int UserId)
        {          
            List<DishS> dishes = new List<DishS>();
            var userproducts = context.userProducts.Where(t => t.UserID == UserId).ToList();
            
            foreach (var item in userproducts)
            {
                try
                {
                var dishestemp = item.ProductV.intermediate.Distinct(new IntermediateEqualityComparer()).Select(t => t.DishV);
                dishes.Add(dishestemp.Select(t => new DishS()
                {
                    ID = t.ID,
                    LittleDescription = t.LittleDescription,
                    Name = t.Name,
                    Recept = t.Recept,
                    TypeID = t.TypeID                   
                }).FirstOrDefault());
                }
                catch (Exception)
                {

                    
                }
            }
            var b = dishes.Distinct(new DishesEqualityComparer());
            
            //dishes = new List<DishS>();
            


            return b.ToList();
        }

        

        public string GetRecipesBot(List<DishS> recipes)
        {
            string recipe = "";
            foreach (var item in recipes)
            {
                recipe += item.Recept + Environment.NewLine;
            }
            return recipe;
        }

    }
}
