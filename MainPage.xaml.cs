using System;
using Microsoft.Maui.Controls;

namespace ListaDePersonas
{
    public partial class MainPage : ContentPage
    {
        DatabaseService databaseService;

        public MainPage()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
            RefreshPeopleList();
        }

        void OnAddPersonClicked(object sender, EventArgs e)
        {
            string nombres = nombresEntry.Text;
            string apellidos = apellidosEntry.Text;

            if (!string.IsNullOrWhiteSpace(nombres) && !string.IsNullOrWhiteSpace(apellidos))
            {
                var person = new Person
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Edad = 0, 
                    Correo = "",
                    Direccion = ""
                };
                databaseService.InsertPerson(person);
                RefreshPeopleList();
                nombresEntry.Text = apellidosEntry.Text = "";
            }
        }

        void RefreshPeopleList()
        {
            peopleListView.ItemsSource = databaseService.GetPeople();
        }
    }
}
