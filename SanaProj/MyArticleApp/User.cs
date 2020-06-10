using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    class User
    {

        private string Profil;
        public string UserProfil
        {
            get
            {
                return Profil;
            }
            set
            {
                Profil = value;
            }
        }
        private string LastName;

        public string UserLastName
        {
            get
            {
                return LastName;
            }
            set
            {
               LastName = value;
            }
        }

        private string FirstName;

        public string UserFirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }

        private string Email;

        public string UserEmail
        {
            get
            {
                return Email; 
            }
            set
            {
                Email = value;
            }
        }
        private string PassWord;
        public string UserPassWord
        {
            get
            {
                return PassWord;
            }
            set
            {
                PassWord = value;
            }
        }


        public User( string lastname, string firstname, string email, string password,string prof)
        {
            
            this.UserLastName = lastname;
            this.UserFirstName = firstname;
            this.UserEmail = email;
            this.UserPassWord = password;
            this.UserProfil = prof;
        }


        public User( )
        {
           
        }

        
    }
}
