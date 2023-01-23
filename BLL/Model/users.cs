namespace BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;
    public  class usersModel
    {

        public long Id_user { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Root { get; set; }

        public usersModel() { }
        public usersModel(users us)
        {
            Id_user = us.Id_user;
            Name = us.Name;
            Surname = us.Surname;
            Email = us.Email;
            Password = us.Password;
            Root = us.Root;

        }
    }
}
