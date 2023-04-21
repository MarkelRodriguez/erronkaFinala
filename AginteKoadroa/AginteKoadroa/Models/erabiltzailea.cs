using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.Models
{
    public partial class erabiltzailea
    {
        public int Id { get; set; }


        public string Izena { get; set; }


        public string Abizena { get; set; }

        //erabiltzailea eremua primary key izango da
        [Key]
        public string Erabiltzailea { get; set; }


        public string Emaila { get; set; }


        public string Pasahitza { get; set; }


        public DateTime Jaiotza_data { get; set; }

    }
}
