using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SQLite;

namespace EsSwagger
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var file = "Database.db3";
            //var con = new SQLiteAsyncConnection(file);

            //Console.WriteLine("INSERISCI L'ID DELLA CLASSE");
            //int idClasse = Convert.ToInt32(Console.ReadLine());

            //var ris = await con.Table<Studente>().
            //    Where(c => c.id_classe == idClasse).
            //    Where(c => c.Nome.StartsWith("L")).
            //    OrderBy(c => c.Cognome).ToListAsync();

            //foreach (Studente s in ris)
            //{
            //    Console.WriteLine($"{s.Nome} {s.Cognome}");
            //}

            //await con.CloseAsync();
            //Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    
        
            

        
    }
}
