using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Library.Models
{
    public class Patient
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(9)]
        public string TAJ { get; set; }


        [Required]
        public string Complaint { get; set; }

        public override string ToString()
        {
            return $"Név: {Name} Cím: {Adress} TAJ: {TAJ} Panasz: {Complaint}";
        }

    }
}
