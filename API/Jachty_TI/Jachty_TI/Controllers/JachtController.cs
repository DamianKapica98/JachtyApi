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
    public class JachtController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"SELECT [J_ID] ,[J_Nazwa],[J_CenaNaDzien] FROM [Jachty].[dbo].[Jacht] ";

            DataTable tabelaJachtow = new DataTable();
            using(var con=new SqlConnection(ConfigurationManager.ConnectionStrings["Jachty"].ConnectionString))
                using (var cmd= new SqlCommand(query,con))
                using (var da=new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(tabelaJachtow);

            }

            return Request.CreateResponse(HttpStatusCode.OK, tabelaJachtow);
        }



    }
}
