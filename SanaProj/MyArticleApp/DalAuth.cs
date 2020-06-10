using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    class DALAuth
    {
        
        private ConnectionBD Connexion;
        private SqlCommand MySqlCommand; 
        private  DataTable dt = new DataTable();

        public DALAuth()
        {
            Connexion = new ConnectionBD();
        }

        static User ConvertRowToUser(DataRow row)
        {

            User CurrentUser = new User();

            string Profil = (row["Profil"].ToString().Length != 0) ? row["Profil"].ToString() : "pas de profil";
            CurrentUser.UserProfil  =Profil;

            string Email = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas de Email";
            CurrentUser.UserEmail=Email;


            string FirstName = (row["FirstName"].ToString().Length != 0) ? row["FirstName"].ToString() : "pas de FirstName";
            CurrentUser.UserFirstName=FirstName ;

            string LastName = (row["LastName"].ToString().Length != 0) ? row["LastName"].ToString() : "pas de LastName";
            CurrentUser.UserLastName = LastName;

            string PassWord = (row["PassWord"].ToString().Length != 0) ? row["PassWord"].ToString() : "pas de PassWord";
            CurrentUser.UserPassWord = PassWord;

           

            return CurrentUser;

        }

         

        public   List<User> GetAllUsers()
        {
            List<User> AllUsers = new List<User>();

            MySqlCommand = new SqlCommand("select * from [Users]");

            dt =  Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllUsers.Add(ConvertRowToUser(row));
            }

            return AllUsers;
        }

       
        public  User GetUserByEmail(string Email)
        {
            User UserSearched = new User();

            MySqlCommand = new SqlCommand("select * from [Users] where Email = @Email");

            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;

            dt = Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                UserSearched = ConvertRowToUser(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return UserSearched;
        }

        public bool LoginUser(User U)
        {
            List<User> AllUsers = new List<User>();
            User temp = new User();
            AllUsers =  GetAllUsers();
            foreach (User user in AllUsers)
            {
                if (user.UserEmail == U.UserEmail  )
                {
                    temp.UserEmail = user.UserEmail;
                    temp.UserPassWord = user.UserPassWord;
                }
            }
            if (temp.UserPassWord == U.UserPassWord)
                return true;

            return false;
        }

        public void AddUser(User newUser )
        {
             
             
            MySqlCommand = new SqlCommand("insert into [Users]( FirstName, LastName, Email,PassWord, Profil )" +
                                         "values ( @FirstName, @LastName,@Email, @PassWord, @Profil)");

            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newUser.UserEmail;

            MySqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = newUser.UserFirstName;

            MySqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = newUser.UserLastName;

            MySqlCommand.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = newUser.UserPassWord;

            MySqlCommand.Parameters.Add("@Profil", SqlDbType.VarChar).Value =newUser.UserProfil;

            Connexion.FunctionToWrite(MySqlCommand);



        }
 
        public void UpdateUser(string Email, User newUser)
        {

            MySqlCommand = new SqlCommand("update [Users]  set Email = @Email, FirstName = @FirstName, LastName = @LastName ,Profil=@Profil where Email = @OldEmail");

            MySqlCommand.Parameters.Add("@OldEmail", SqlDbType.VarChar).Value = Email;

            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newUser.UserEmail;

            MySqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = newUser.UserFirstName;

            MySqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = newUser.UserLastName;

            MySqlCommand.Parameters.Add("@PassWord", SqlDbType.VarChar).Value = newUser.UserPassWord;
            MySqlCommand.Parameters.Add("@Profil", SqlDbType.VarChar).Value = newUser.UserProfil;


            Connexion.FunctionToWrite(MySqlCommand);

        }
 
        public   void DeleteUser(string Email)
        {

            MySqlCommand = new SqlCommand("delete from [Users] where Email= @Email ");

            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email;


            Connexion.FunctionToWrite(MySqlCommand);

        }
        

    }
}
