using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWindow2.Data.Entities
{
    internal class SettingEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string IpAdress { get; set; }
        public int Port { get; set; }
    }
}
