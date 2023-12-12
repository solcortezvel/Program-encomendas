using System;
using System.Collections.Generic;
using System.Text;

namespace ex0tutorial5.Entities
{
    class Client
    {
        private string name; 
        private string email; 
        private DateTime birthday;
        public Client(string name, string email, DateTime birthday)
        {
            this.name = name;
            this.email = email;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return $"\n\n##### Dados do cliente #####\n\tNome: {name}\n\tEmail: {email}\n\tData de nascimento: {birthday.ToLongDateString()}";
        }
    }
}
