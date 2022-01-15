using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace Jachty_TI.Models
{
    public class Rezerwacja
    {
        DateTime r_datawypozyczenia;
        DateTime r_dataoddania;
        string r_email;

       
        public DateTime R_DataWypozyczenia {
            get
            {
                return r_datawypozyczenia;
            }

            set
            {
                if (value > DateTime.Now) { r_datawypozyczenia = value; }
                else {  }

            }
                 }
        public DateTime R_DataOddania {
            get
            {
                return r_dataoddania;
            }


            set
            {
                if (value > DateTime.Now && value > r_datawypozyczenia) { r_dataoddania = value; }
            }
            } 
        public string R_Email { 
            get 
            {

                return r_email;
            } 
            set 
            { 
            if(new EmailAddressAttribute().IsValid(r_email)) { r_email = value; }
            
            } 
        }
        public int R_J_ID { get; set; }
    }

}