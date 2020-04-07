using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
   public class Program
    {
        static async Task Main(string[] args)
        {
            var file = "Database2.db3";
            var con = new SQLiteAsyncConnection(file);

            Console.WriteLine("INSERISCI L'ID DELLA CLASSE");
            int idClasse = Convert.ToInt32(Console.ReadLine());

            var ris = await con.Table<Studente>().
                Where(c => c.id_classe == idClasse).
                Where(c => c.Nome.StartsWith("L")).
                OrderBy(c => c.Cognome).ToListAsync();

            foreach (Studente s in ris)
            {
                Console.WriteLine($"{s.Nome} {s.Cognome}");
            }

            await con.CloseAsync();
            Console.ReadLine();
        }
    }
}
