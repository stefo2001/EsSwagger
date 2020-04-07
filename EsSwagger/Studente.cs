using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsSwagger
{
    public class Studente
    {
        [PrimaryKey]
        public int ID { get; set; }

        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(255), NotNull]
        public string Cognome { get; set; }

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Classe))]
        public int id_classe { get; set; }
    }
}
