using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data
{
    public class DataAccess
    {
        //USERS

        public void CreateUser(User user)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("The username already exist...");
            }

        }

        public User ReadUser(string username)
        {
            using (var context = new Context())
            {
                return context.Users
                    .AsNoTracking()
                    .FirstOrDefault(c => c.Username == username);
            }
        }

        public List<string> ReadUsers()
        {
            using (var context = new Context())
            {
                return context.Users
                    .AsNoTracking()
                    .Select(c => c.Username)
                    .ToList();
            }
        }

        public void UpdateUser(User userModified)
        {
            using (var context = new Context())
            {
                var user = context.Users
                    .FirstOrDefault(c => c.Username == userModified.Username);

                if (userModified.Password == null || userModified.Password == "")
                {
                    throw new Exception("Password can't be empty...");
                }

                if (user != null)
                {
                    user.Password = userModified.Password;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The username doesn't exist...");
                }

            }
        }

        public void DeleteUser(string username)
        {
            using (var context = new Context())
            {
                var user = context.Users
                    .FirstOrDefault(c => c.Username == username);

                if (user != null)
                {
                    try
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    catch (Exception)
                    {

                        throw new Exception("Can't delete this user...");
                    }
                }
                else
                {
                    throw new Exception("The username doesn't exist...");
                }

            }
        }

        //NEWS

        public void CreateNew(New news)
        {
            using (var context = new Context())
            {

                news.CreatedBy = context.Users
                    .Where(c => c.Username == news.CreatedBy.Username)
                    .FirstOrDefault();

                if (news.EditedBy != null)
                    news.EditedBy = context.Users
                        .Where(c => c.Username == news.EditedBy.Username)
                        .FirstOrDefault();

                context.News.Add(news);
                context.SaveChanges();

            }
        }

        public New ReadNew(int id)
        {
            using (var context = new Context())
            {
                return context.News
                    .Include(c => c.CreatedBy)
                    .Include(c => c.EditedBy)
                    .AsNoTracking()
                    .Where(c => c.NewID == id)
                    .FirstOrDefault();
            }
        }

        public List<New> ReadNews()
        {
            using (var context = new Context())
            {
                return context.News
                    .Include(c => c.CreatedBy)
                    .Include(c => c.EditedBy)
                    .AsNoTracking()
                    .ToList();
            }
        }

        public void UpdateNew(New newEdited)
        {
            using (var context = new Context())
            {
                User editedBy;

                var news = context.News
                    .Where(c => c.NewID == newEdited.NewID)
                    .FirstOrDefault();

                if (newEdited.EditedBy != null)
                {
                    editedBy = context.Users
                    .Where(c => c.Username == newEdited.EditedBy.Username)
                    .FirstOrDefault();
                    
                    news.EditedBy = editedBy;
                }

                news.Title = newEdited.Title;
                news.Description = newEdited.Description;


            }
        }

        public void DeleteNew(int id)
        {
            using (var context = new Context())
            {

            }
        }
    }
}
