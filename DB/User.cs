using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDBSave.DB
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } = ""; //Тестовое значение
        public string Password { get; set; }
        public string Login { get; set; }
        public string UserImage { get; set; } = ""; //Тестовое значение
        public string StatusUser { get; set; }

        public override string ToString() => $"{Name}{StatusUser}";
    }
}
