using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDBSave.DB
{
    public class UserImage
    {
        [Key]
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
