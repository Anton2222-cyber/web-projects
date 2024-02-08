using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendToEmail.Data.Entities
{
    [Table("tblUsers")]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(300)]
        public string FullName { get; set; }
        [Required, StringLength(200)]
        public string NumberPhone { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
       
    }
}
