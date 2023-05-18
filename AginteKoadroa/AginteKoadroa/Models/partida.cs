﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa.Models
{
    public partial class partida
    {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        public int Puntuazioa { get; set; }
        [ForeignKey("Id")]
        public virtual erabiltzailea Erabiltzailea{ get; set; }

    

    }
}
