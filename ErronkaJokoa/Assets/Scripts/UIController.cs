using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Data;
using Mono.Data.Sqlite;
using System;
using Npgsql;

public class UIController : MonoBehaviour
{
    Player player;
    TextMeshProUGUI distanceText;
    int puntuazioa;
    GameObject results;
    Text finalDistanceText;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<TextMeshProUGUI>();
        results = GameObject.Find("Results");
        finalDistanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();
        
        results.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + " m";

        if (player.isDead)
        {
            results.SetActive(true);
            finalDistanceText.text = distance + " m";
            puntuazioa = distance;
            
        }
        
    }


    public void Quit()
    {
        SQLPartidaGorde(puntuazioa);
         Application.Quit();
    }
       

    public void Retry()
    {
        SceneManager.LoadScene("Jokua");
        SQLPartidaGorde(puntuazioa);
    }

    public void SQLPartidaGorde(int puntuazioa)
    {

        string connection = "Host=192.168.1.53;Username=markel;Password=markel;Database=erronkafinala";
        string sql = "insert into partida(erabiltzailea,data,puntuazioa) values ('" + PlayerPrefs.GetString("Erabiltzailea") + "','" + DateTime.Now + "'," + puntuazioa + ")";

        NpgsqlConnection conn;


        conn = new NpgsqlConnection(connection);
        conn.Open();


        NpgsqlCommand command = new NpgsqlCommand(sql, conn);
        
            
            // Execute the command
            command.ExecuteNonQuery();
            
            Debug.Log("Data inserted into the database.");

        conn.Close();
        
    }

}
