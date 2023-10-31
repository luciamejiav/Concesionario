﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Concesionario.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text.RegularExpressions;


namespace Concesionario.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
       
        private GestorDeDatos gestorDeDatos;

        private ObservableCollection<Coche> listaCoches;

        public ObservableCollection<Coche> ListaCoches
        {
            get { return listaCoches; }
            set
            {
                listaCoches = value;
                OnPropertyChanged("ListaCoches");
            }
        }

        private Coche cocheSeleccionado;
        public Coche CocheSeleccionado
        {
            get { return cocheSeleccionado; }
            set
            {
                cocheSeleccionado = value;
                OnPropertyChanged("CocheSeleccionado");

                if (cocheSeleccionado == null)
                    ActivarEliminacionYEdicion = false;
                else
                {
                    ActivarEliminacionYEdicion = true;

                    Modelo = cocheSeleccionado.Modelo;
                    Marca = cocheSeleccionado.Marca;
                    TipoMotor = cocheSeleccionado.TipoMotor;
                    Stock = cocheSeleccionado.Stock;
                    Precio = cocheSeleccionado.Precio;
                    Año = cocheSeleccionado.Año;

                  
    }
            }
        }

        private bool activarEliminacionYEdicion;

        public bool ActivarEliminacionYEdicion
        {
            get { return activarEliminacionYEdicion; }
            set
            {
                activarEliminacionYEdicion = value;
                OnPropertyChanged("ActivarEliminacionYEdicion");
            }
        }

        public ICommand ComandoNuevoCoche{ get; set; }
        public ICommand ComandoEliminarCoche { get; set; }
        public ICommand ComandoGuardarTodo { get; set; }

        public MainViewModel()
        {
           

            gestorDeDatos = new GestorDeDatos();

            Coche[] coches = gestorDeDatos.LeerTodosLosRegistros();
            ListaCoches = new ObservableCollection<Coche>(coches);

            ComandoNuevoCoche = new Command(AccionNuevoCoche);
            ComandoEliminarCoche = new Command(AccionEliminarCoche);
            ComandoGuardarTodo = new Command(AccionGuardarTodo);
        }

        private void AccionGuardarTodo(object parametro)
        {
            gestorDeDatos.Guardar(ListaCoches);
        }

        private void AccionEliminarCoche(object parametro)
        {
            if (CocheSeleccionado != null)
            {
                ListaCoches.Remove(CocheSeleccionado);

                Modelo = "";
                Marca = "";
                TipoMotor = "";
                Stock = "";
                Precio = "";
                Año = "";

            }
        }

        private void AccionNuevoCoche(object parametro)
        {

            if (CocheSeleccionado != null)
            {
                CocheSeleccionado.Modelo = Modelo;
                CocheSeleccionado.Marca = Marca;
                CocheSeleccionado.TipoMotor = TipoMotor;
                CocheSeleccionado.Stock = Stock;
                CocheSeleccionado.Precio = Precio;
                CocheSeleccionado.Año = Año;



                OnPropertyChanged("CocheSeleccionado");

                //Refrescamos el LisBox después de modificar el elemento modificado
                gestorDeDatos.Guardar(ListaCoches);
                Coche[] coches = gestorDeDatos.LeerTodosLosRegistros();
                ListaCoches = new ObservableCollection<Coche>(coches);

            }
            else
            {
                Coche coche = new Coche { Modelo = Modelo, Marca = Marca, TipoMotor = TipoMotor, Stock = Stock, Precio = Precio, Año = Año };
                ListaCoches.Add(coche);
            }

            Modelo = "";
            Marca = "";
            TipoMotor = "";
            Stock = "";
            Precio = "";
            Año = "";

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set
            {
                modelo = value;
                OnPropertyChanged("Modelo");


            }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set
            {
                marca = value;
                OnPropertyChanged("Apellidos");
            }
        }

        private string tipoMotor;
        public string TipoMotor
        {
            get { return tipoMotor; }
            set
            {
                tipoMotor = value;
                OnPropertyChanged("TipoMotor");
            }
        }

        private string stock;
        public string Stock
        {
            get { return stock; }
            set
            {
                stock = value;
                OnPropertyChanged("Stock");


            }
        }

        private string precio;
        public string Precio
        {
            get { return precio; }
            set
            {
                precio = value;
                OnPropertyChanged("Precio");


            }
        }

        private string año;
        public string Año
        {
            get { return año; }
            set
            {
                año = value;
                OnPropertyChanged("Año");


            }
        }


    }
}
