using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Data
{
    public class Vare
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public float Pris { get; set; }
        public int Raekkefoelge { get; set; }
    }

    public class Drink
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public DateTime Tidsstempel { get; set; }
        public List<Vare> Ingrediense { get; set; }
    }

    public class VareItem
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public bool ErDrink { get; set; }
    }
}
