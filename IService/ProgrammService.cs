using IService.Entities;
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

namespace IService
{
    public class ProgrammService:IProgrammService
    {        
        private MyBot myBotCLient = new MyBot("826922838:AAGGlwgZhCQyBaSJsjwQ-iq4XRyJQunh4JE");
        Context context = new Context();
        // List<UserS> users;
        
        public string Msg(string msg)
        {
            return msg;
        }
        public UserS GetEmptyUser()
        {
            return new UserS();
        }
        public void AddUser(UserS user)
        {
            context.users.Add(new User() { Name = user.Name, Login=user.Login, DateOfBirth=user.DateOfBirth, DateOfRegister=user.DateOfRegister, Email=user.Email, ISConfirmed=user.ISConfirmed, Password=user.Password, Surname=user.Surname, TelegramID=user.TelegramID, DoesWantRecomendations=user.DoesWantRecomendations });
            context.SaveChangesAsync();
        }
        public bool IsEmailUnique(string email)
        {
            foreach (var item in context.users)
            {
                if(item.Email== email)
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
                if (item.Login == login&& item.Password==password)
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
            return users.Where(t=>t.ID==ID).FirstOrDefault();
        }

        public List<UserS> GetUsers()
        {
            
            //var users1 = context.users.ToList();
            var users= context.users.Select(t => new UserS()
            {
                ID =t.ID,
                Name =t.Name,
                Surname =t.Surname,
                Login =t.Login,
                Password =t.Password,
                TelegramID =t.TelegramID,
                Email =t.Email,
                ISConfirmed =t.ISConfirmed,
                DateOfBirth =t.DateOfBirth,
                DateOfRegister =t.DateOfRegister,
                DoesWantRecomendations =t.DoesWantRecomendations
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
            var users = context.users.Where(t=>t.ID.ToString().Contains(prop) || 
            t.Name.Contains(prop)|| t.Email.Contains(prop)||t.Surname.Contains(prop)||
            t.Password.Contains(prop)||t.TelegramID.Contains(prop)).Select(t => new UserS()
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
            foreach(var item in productS)
            {

               // context.product
            }
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
            context.products.Remove(context.products.Where(t=>t.ID==ID).First());
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
            return (context.dishes.Select(t => new DishS() { ID = t.ID, Image = t.Image, LittleDescription = t.LittleDescription, Name = t.Name, Recept = t.Recept, TypeID = t.TypeID }).ToList());
        }
        public DishS GetEmptyDishS()
        {
            return new DishS();
        }
        public void AddDishS(DishS dish)
        {
            context.dishes.Add(new Dish() { ID = dish.ID, Image = dish.Image, LittleDescription = dish.LittleDescription, Name = dish.Name, Recept = dish.Recept, TypeID = dish.TypeID });
            context.SaveChanges();
        }
        public DishS GetDishSById(int ID)
        {
            return (context.dishes.Select(t => new DishS() { ID = t.ID, Image = t.Image, LittleDescription = t.LittleDescription, Name = t.Name, Recept = t.Recept, TypeID = t.TypeID }).ToList()).Where(t=>t.ID==ID).First();
        }
        public void UpdateDish(DishS dish)
        {
            context.dishes.Where(t => t.ID == dish.ID).First().Name = dish.Name;
            context.dishes.Where(t => t.ID == dish.ID).First().Image = dish.Image;
            context.dishes.Where(t => t.ID == dish.ID).First().LittleDescription = dish.LittleDescription;
            context.dishes.Where(t => t.ID == dish.ID).First().Recept = dish.Recept;
            context.dishes.Where(t => t.ID == dish.ID).First().TypeID = dish.TypeID;
            context.SaveChanges();
        }
        public void DeleteDishByID(int ID)
        {
            context.dishes.Remove(context.dishes.Where(t => t.ID == ID).First());
            context.SaveChanges();
        }
        public void StartBot()
        {
            if(myBotCLient.IsStarted==false)
            myBotCLient.StartBot();
        }
        public void StopBot()
        {            
            if(myBotCLient.IsStarted==true)
            myBotCLient.Stop();
        }
        public string GetStatusMsg()
        {
            string msg = myBotCLient.StatusMsg;
            return msg;
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

        public void SaveImages()
        {
            var AndrewPidor = new List<byte[]>();
            foreach (var item in context.dishes)
            {
                File.WriteAllBytes(@"Images\" + item.ID + ".jpg", item.Image);
            }


        }


    }
}
