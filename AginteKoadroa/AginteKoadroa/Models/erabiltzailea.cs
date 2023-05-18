using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.Models
{
    public partial class erabiltzailea
    {
        
        public string Erabiltzailea { get; set; }
        [Key]
        public int Id { get; set; }


        public string Izena { get; set; }


        public string Abizena { get; set; }
 

        public string Emaila { get; set; }


        public string Pasahitza { get; set; }


        public string Jaiotza_data { get; set; }

        public virtual List<partida> Partida { get; set; }

 
    } 
}
