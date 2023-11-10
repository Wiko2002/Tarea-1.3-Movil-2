﻿using SQLite;

public class Person
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
}
