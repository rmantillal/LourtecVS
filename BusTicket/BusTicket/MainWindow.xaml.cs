using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusTicket.Models;

namespace BusTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Reserva Reserva { get; set; }
        public List<Rutas> Rutas { get; set; }

        public List<Localizacion> Estaciones { get; set; }

        public MainWindow()
        {
            Estaciones = new List<Localizacion>()
            {
                new Localizacion()
                {
                    Ciudad = "Lima",
                    Estacion="Lima Central",
                    Estado = "Lima",
                    Pais = "Perú",

                },
                new Localizacion()
                {
                    Ciudad = "Trujillo",
                    Estacion="Central Trujillo",
                    Estado = "Trujillo",
                    Pais = "Perú"

                }
            };

            Reserva = new Reserva()
            {
                Destino = Estaciones[0],
                Salida = Estaciones[1],
                Fecha = DateTime.Now,
            };
            Rutas = new List<Models.Rutas>()
            {
                    new Rutas()
                    {
                        Chofer = "XYZ",
                        Compania = "Z",
                        Estaciones  = Estaciones,
                        FechaFin=DateTime.Now.AddDays(2),
                        FechaInicio = DateTime.Now,
                        Id  = Guid.NewGuid(),
                    }
            };

            InitializeComponent();

            this.Origen.ItemsSource = Estaciones;
            this.Origen.SelectedItem = Reserva.Salida;
            this.Destino.ItemsSource = Estaciones;
            this.Destino.SelectedItem = Reserva.Destino;
            this.DiaViaje.SelectedDate = Reserva.Fecha;
        }
    }
}
