using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{

    
    
    class Motor : VehiculoComponente

    {
        private int _id;
        private string _tipo;
        private double _cilindrada;

        public Motor(int id, string tipo, double cilindrada)
        {
            Id = id;
            Tipo = tipo;
            _cilindrada = cilindrada;
        }

        

       

        public double Cilindrada { get => _cilindrada; set => double.TryParse(value.ToString(), out _cilindrada); }
        public int Id { get => _id; set => _id = value; }
        internal string Tipo { get => _tipo; set => _tipo = value; }
    }
}
