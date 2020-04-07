using System;
using System.Collections.Generic;

namespace EsSwagger
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Covid19_Data
    {
        public DateTime Data { get; set; }

        public int NuoviPositivi { get; set; }

        //public int NuoviDecessi { get; set; }

        public string Regione { get; set; }

        public Covid19_Data(DateTime data, string regione,int positivi)//int decessi)
        {
            this.Data = data;
            this.Regione = regione;
            this.NuoviPositivi = positivi;
            //this.NuoviDecessi = decessi;
        }
    }
    public class RepositoryCovid
    {
        public List<Covid19_Data> LoadCovidUmbria()
        {
            List<Covid19_Data> listNuoviPositivi = new List<Covid19_Data>();

            Covid19_Data r0 = new Covid19_Data(new DateTime(2020, 03, 17), "Umbria", 197);//,0);
            listNuoviPositivi.Add(r0);
            Covid19_Data r1 = new Covid19_Data(new DateTime(2020, 03, 18), "Umbria", 247);//,2);
            listNuoviPositivi.Add(r1);
            Covid19_Data r2 = new Covid19_Data(new DateTime(2020, 03, 19), "Umbria", 334);//,6);
            listNuoviPositivi.Add(r2);

            return listNuoviPositivi;
        }

      
    }

}
