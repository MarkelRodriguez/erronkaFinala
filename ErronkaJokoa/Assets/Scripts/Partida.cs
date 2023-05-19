using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Partida
{
    public int id { get; set; }
    public string data { get; set; }
    public int puntuazioa { get; set; }
    public string erabiltzailea { get; set; }

    public Partida()
    {
        id = 0;
        data = "";
        puntuazioa = 0;
        erabiltzailea = "";
    }

    public Partida(int id, string erabiltzailea, string data, int puntuazioa)
    {
        this.id = id;
        this.data = data;
        this.puntuazioa = puntuazioa;
        this.erabiltzailea = erabiltzailea;
    }
}


