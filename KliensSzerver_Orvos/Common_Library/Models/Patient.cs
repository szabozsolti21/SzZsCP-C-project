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
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }

        [Required]
        [MaxLength(9)]
        public string TAJ { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Complaint { get; set; }

        public override string ToString()
        {
            return $"Név: {FirstName} {LastName} Cím: {Adress} TAJ: {TAJ} Panasz: {Complaint}";
        }

    }
}
