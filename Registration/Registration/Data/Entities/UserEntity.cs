using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Data.Entities
{
    [Table("tblUsers")]
    internal class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Nickname { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        [Required, StringLength(300)]
        public string PhotoUrl { get; set; }
    }
}
