using System;
using System.Collections.Generic;
using System.IO;
using SQLite;

public class DatabaseService
{
    SQLiteConnection database;

    public DatabaseService()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "People.db");
        database = new SQLiteConnection(dbPath);
        database.CreateTable<Person>();
    }

    public List<Person> GetPeople()
    {
        return database.Table<Person>().ToList();
    }

    public int InsertPerson(Person person)
    {
        return database.Insert(person);
    }

    public int UpdatePerson(Person person)
    {
        return database.Update(person);
    }

    public int DeletePerson(int personId)
    {
        return database.Delete<Person>(personId);
    }
}
