using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Provincia
    {
        
        public string Nombre { get; set; }
        public string Gobernador { get; set; }
        public string Region { get; set; }
        public List<Ciudad> Ciudades { get; set; }
        public Provincia() 
        {
            Ciudades = new List<Ciudad>();
        }
    }
}

