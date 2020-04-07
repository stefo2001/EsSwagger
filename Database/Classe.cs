using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class Classe
    {
        [PrimaryKey]
        public int ID { get; set; }

        [MaxLength(255), NotNull]
        public string Nome { get; set; }

        [MaxLength(255)]
        public string Indirizzo { get; set; }
    }
}
