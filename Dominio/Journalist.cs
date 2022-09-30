using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Journalist
    {
        #region Attributes
        private int id;
        private static int lastId;
        private string name;
        private string mail;
        private string password;
        #endregion

        #region Properties
        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region Constructors
        public Journalist(string name, string mail, string password)
        {
            this.id = ++lastId;
            this.name = name;
            this.mail = mail;
            this.password = password;
        }
        #endregion

        #region Methods
        public Boolean Validate()
        {
            if (this.name == null || !name.Contains(" ")) return false;
            if (this.mail == null) return false;
            if (this.password == null) return false;
            if (!this.mail.Contains("@") || mail.StartsWith("@") || mail.EndsWith("@")) return false;
            if (this.password.Length < 8) return false;
            return true;
        }
        #endregion
    }
}
