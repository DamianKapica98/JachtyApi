using Jachty_TI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jachty_TI.Controllers
{
    public class RezerwacjaController : ApiController
    {

        public HttpResponseMessage Get()
        {
            string query = @" 
                            SELECT [R_ID] ,convert(varchar,[R_DataWypozyczenia],20) as [R_DataWypozyczenia],convert(varchar,[R_DataOddania],20) as [R_DataOddania],[J_Nazwa] as R_J_ID, substring([R_Email],1,2)+'***'+SUBSTRING([R_Email], CHARINDEX('@', [R_Email]), LEN([R_Email])) as [R_Email] FROM [Jachty].[dbo].[Rezerwacja] join Jacht on J_ID=R_J_ID";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Jachty"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);

            }

            return Request.CreateResponse(HttpStatusCode.OK, table);
        }


        public string Post(Rezerwacja rezerwacja)
        {
            try
            {
                string query = @" 
                    if not exists(select * from rezerwacja where R_J_ID='"+rezerwacja.R_J_ID+ @"' and ((convert(datetime,'" + rezerwacja.R_DataWypozyczenia + @"',105)  between R_DataWypozyczenia and R_DataOddania)))
                    begin
                    insert into Rezerwacja(R_DataWypozyczenia,R_DataOddania,R_Email,R_J_ID) values(convert(datetime,'" + rezerwacja.R_DataWypozyczenia + @"',105),convert(datetime,'"+rezerwacja.R_DataOddania+@"',105),'"+rezerwacja.R_Email+@"','"+rezerwacja.R_J_ID+ @"') 
                    end
                    else
					begin
					RAISERROR ('Statek jest już zarezerwowany w tym okresie',16,1); 
					end";


                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Jachty"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);

                }

                return "Dodano rezerwację!";
            }
            catch (Exception)
            {
                return "Błąd podczas dodawania rezerwacji! Sprawdź wprowadzone dane.";
            }

        }




     

    }

}


