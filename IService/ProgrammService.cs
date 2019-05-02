using IService.Entities;
using IService.EntitiesReturn;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace IService
{
    public class ProgrammService:IProgrammService
    {
        Context context = new Context();
       // List<UserS> users;
        public string Msg(string msg)
        {
            return msg;
        }
        public User GetEmptyUser()
        {
            return new User();
        }
        public void AddUser(User user)
        {
            context.users.Add(user);
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
        public List<UserS> GetUsers()
        {
            
            //var users1 = context.users.ToList();
            var users= context.users.Select(t => new UserS() { ID =t.ID, Name=t.Name, Surname=t.Surname, Login=t.Login, Password=t.Password, TelegramID=t.TelegramID, Email=t.Email, ISConfirmed=t.ISConfirmed, DateOfBirth=t.DateOfBirth,DateOfRegister=t.DateOfRegister,DoesWantRecomendations=t.DoesWantRecomendations}).ToList();
            return users;
        }
        public void RemoveUserS(UserS user)
        {
            int ID = user.ID;
            context.users.Remove(context.users.Where(item=>item.ID==ID).First());
            context.SaveChanges();
        }
        public List<UserS> FindUsersByProp(string prop)
        {
            var users = context.users.Where(t=>t.ID.ToString().Contains(prop) || t.Name.Contains(prop)||t.DateOfBirth.ToLongDateString().Contains(prop)||t.Email.Contains(prop)||t.Surname.Contains(prop)||t.Password.Contains(prop)||t.TelegramID.Contains(prop)).Select(t => new UserS() { ID = t.ID, Name = t.Name, Surname = t.Surname, Login = t.Login, Password = t.Password, TelegramID = t.TelegramID, Email = t.Email, ISConfirmed = t.ISConfirmed, DateOfBirth = t.DateOfBirth, DateOfRegister = t.DateOfRegister, DoesWantRecomendations = t.DoesWantRecomendations }).ToList();
            return users;
        }
    }
}
