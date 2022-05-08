using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Library.Models
{
    public class Patient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string TAJ { get; set; }
        public string Compaint { get; set; }

        public override string ToString()
        {
            return $"Név: {Name} Cím: {Adress} TAJ: {TAJ} Panasz: {Compaint}";
        }

    }
}
