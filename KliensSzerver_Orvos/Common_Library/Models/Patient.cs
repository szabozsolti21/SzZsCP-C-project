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
        [MaxLength(15)]
        public string TAJ { get; set; }

        [Required]
        public string Complaint { get; set; }
        [Required]
        public DateTime TimeOfArrival { get; set; }
        [MaxLength(100)]
        public string Diagnose { get; set; }


        public override string ToString()
        {
            return $"Név:\t{Name}\n\n" +
                   $"Lakcím:\t\t\t{Adress}\n" +
                   $"TAJ szám:\t\t{TAJ}\n" +
                   $"Bejelentkezés ideje:\t{TimeOfArrival}\n" +
                   $"Panasz:\t\t\t{Complaint}\n" +
                   $"Diagnózis:\t\t{Diagnose}\n";
        }

    }
}
