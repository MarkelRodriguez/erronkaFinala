using Mono.Data.Sqlite;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;//Edozein script-etik deitu ahal izateko
    [Header("Puntuazioa")]
    public TextMeshProUGUI puntuazioaTxt;
    private int puntuazioa;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        //DatuBaseanGorde();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void SQLPartidaGorde()
    {
        List<Partida> partidak = new List<Partida>();
        string connection = "URI=file:" + Application.dataPath + "/jokoadb.db";
        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader; 
        string query = "insert into partida(erabiltzailea_name,data,puntuazioa) values ('"+PlayerPrefs.GetString("Erabiltzailea")+"','"+DateTime.Now+"',"+puntuazioa+")";
        cmnd_read.CommandText = query;
        cmnd_read.ExecuteNonQuery();
        dbcon.Close();
    }

    public void PartidaGorde()
    {
        SQLPartidaGorde();
        /*List<DatosPartida> partidak = SaveSystem.CargarDatos();
        DatosPartida jokatutakoPartida;
        if (partidak != null)
        {
            jokatutakoPartida = new DatosPartida(partidak.Count, puntuazioa, DateTime.Now, PlayerPrefs.GetString("Erabiltzailea"));
        }
        else
        {
            partidak= new List<DatosPartida>();
            jokatutakoPartida = new DatosPartida(1, puntuazioa, DateTime.Now, PlayerPrefs.GetString("Erabiltzailea"));
        }
        Debug.Log(jokatutakoPartida.ToString());
        Debug.Log("Partidas totales: " + partidak.Count);
        partidak.Add(jokatutakoPartida);
        SaveSystem.GuardarDatos(partidak);*/
    }

   /* public void DatuBaseanGorde()
    {
        try
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=192.168.65.95;Port=5432;Username=postgres;Password=mahi;Database=erronka2");
            conn.Open();
            List<DatosPartida> gordetakoPartidak = SaveSystem.CargarDatos();


            for(int i = 0; i < gordetakoPartidak.Count; i++) {
                if (ErabiltzaileaExistitzenDa(gordetakoPartidak[i].erabiltzailea))
                {
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO public.partida(id, data, puntuazioa, erabiltzailea)VALUES((select coalesce(max(id) + 1, 1)from partida), '2023-02-02', "+gordetakoPartidak[i].puntuazioa+",'"+gordetakoPartidak[i].erabiltzailea+"'); ", conn);

                    command.ExecuteNonQuery();
                    Debug.Log("Datuak gorde dira");
                }
                else
                {
                    Debug.Log("Ez da erabiltzailea aurkitu");
                }
            }         
            conn.Close();
            SaveSystem.BorrarDatos();
        }
        catch (NpgsqlException e)
        {
            //Debug.LogException(e);
            Debug.Log("Ezin izan dira datuak gorde");
        }
    }*/


    /*Sartutako erabiltzailea existitzen dela konprobatzeko metodoa*/
    /*private bool ErabiltzaileaExistitzenDa(string erabiltzailea)
    {
        try
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=192.168.65.95;Port=5432;Username=postgres;Password=mahi;Database=erronka2");
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("select erabiltzailea from langilea l", conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].Equals(erabiltzailea))
                {
                    return true;
                }
            }
            conn.Close();
        }
        catch (NpgsqlException e)
        {
            Debug.LogException(e);
        }
        return false;
    }
    */
    public void PuntuazioaGehitu(int puntos)
    {
        puntuazioa += puntos;
        puntuazioaTxt.text = puntuazioa.ToString("0000");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Juego");
    }
}
