using AginteKoadroa.Models;
using Npgsql;
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
            List<int> puntuazioak = new List<int>();
            string connection = "Host=192.168.1.53;Username=markel;Password=markel;Database=erronkafinala";
            string sql = "SELECT Erabiltzailea, Puntuazioa FROM partida WHERE Erabiltzailea = @erabiltzailea  ORDER BY Puntuazioa DESC LIMIT 5;";
            NpgsqlConnection conn;


            conn = new NpgsqlConnection(connection);
            conn.Open();
            

            NpgsqlCommand command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;



            NpgsqlDataReader reader = command.ExecuteReader();
           
                    while (reader.Read())
                    {
                        
                        string name = reader.GetString(0);
                        puntuazioak.Add(reader.GetInt32(1));

                        
                    }
                    var kontrolak = grafikoa1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();
                        foreach (var kontrola in kontrolak)
                        {



                            kontrola.Series[0].Points.DataBindY(puntuazioak);

                          
                        }

     

           
        }
        
    }
}
