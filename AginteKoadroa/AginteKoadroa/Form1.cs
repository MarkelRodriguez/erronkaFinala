using AginteKoadroa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CombBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new ErronkaDB())
            {
                var puntuazioa = db.partida


               .Include("erabiltzailea")
               .Where(b => b.Erabiltzailea.Equals(CombBoxUsers.Text) )
               
               .Take(5)
               .ToDictionary( g => g.Puntuazioa);


                if (puntuazioa != null)
                {
                    if (puntuazioa.Count > 0)
                    {
                        var kontrolak = grafikoa1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var kontrola in kontrolak)
                        {
                            
                            
                            kontrola.DataSource = puntuazioa;
                            kontrola.Series[0].YValueMembers = "Value";
                            
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }
    }
}
