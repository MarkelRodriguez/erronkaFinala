using AginteKoadroa.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            string sql = "SELECT Erabiltzailea, Puntuazioa FROM partida WHERE erabiltzailea = @erabiltzailea  ORDER BY Puntuazioa DESC LIMIT 5;";
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

                grafikoa1.chart1.Titles[0].Text = "Stock gutxiago duten produktuak";

                kontrola.Series[0].Points.DataBindY(puntuazioak);


            }

            lstViewPartidak.Clear();
            lstViewPartidak.Columns.Add("id");
            lstViewPartidak.Columns.Add("erabiltzailea",100);
            lstViewPartidak.Columns.Add("puntuazioa",150);
            lstViewPartidak.Columns.Add("data",100);



            conn = new NpgsqlConnection(connection);
            conn.Open();
            sql = "select id, erabiltzailea, puntuazioa, data from partida where Erabiltzailea = @erabiltzailea ";

            command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetInt32(0).ToString());
                item.SubItems.Add(reader.GetString(1).ToString());
                item.SubItems.Add(reader.GetInt32(2).ToString());
                DateTime timestampValue = reader.GetDateTime(3);
                string data = timestampValue.ToString("yyyy-MM-dd");

                item.SubItems.Add(data);

                lstViewPartidak.Items.Add(item);

            }
            reader.Close();
            conn.Close();


            conn = new NpgsqlConnection(connection);
            conn.Open();
            sql = "select izena from erabiltzailea where Erabiltzailea = @erabiltzailea ";

            command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                label1.Visible= true;
                label1.Text = reader.GetString(0); 
            }

            conn = new NpgsqlConnection(connection);
            conn.Open();
            sql = "select abizena from erabiltzailea where Erabiltzailea = @erabiltzailea ";

            command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                label4.Visible = true; 
                label4.Text = reader.GetString(0);
            }

            conn = new NpgsqlConnection(connection);
            conn.Open();
            sql = "select emaila from erabiltzailea where erabiltzailea = @erabiltzailea ";

            command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                label6.Visible = true;
                label6.Text = reader.GetString(0);
            }

            conn = new NpgsqlConnection(connection);
            conn.Open();
            sql = "select jaiotza_data from erabiltzailea where Erabiltzailea = @erabiltzailea ";

            command = new NpgsqlCommand(sql, conn);

            command.Parameters.Add("@erabiltzailea", NpgsqlTypes.NpgsqlDbType.Varchar);
            command.Parameters["@erabiltzailea"].Value = CombBoxUsers.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                label8.Visible = true;
                DateTime timestampValue = reader.GetDateTime(0);
                string data = timestampValue.ToString("yyyy-MM-dd");
                label8.Text = data;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "Host=192.168.1.53;Username=markel;Password=markel;Database=erronkafinala";
            string sql = "SELECT Erabiltzailea FROM partida group by erabiltzailea ;";
            NpgsqlConnection conn;


            conn = new NpgsqlConnection(connection);
            conn.Open();


            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CombBoxUsers.Items.Add(reader.GetString(0));
            }

        }


    }

}
