using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{
    abstract class VehiculoComponente
    {
        private double _estado;
        public VehiculoComponente() 
        {
            _estado = 100.0;
        }
        public double Estado { get => _estado; set => double.TryParse(value.ToString(), out _estado);}



    }
}
