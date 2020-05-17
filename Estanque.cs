using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{
    class Estanque : VehiculoComponente

    {
        private  double _capacidad;
        private double _litros;
        private bool BajoCombustible;
        private bool MitadCombustible;
        private bool MedioLleno;
        
        public Estanque(double capacidad)
        {
            _capacidad = capacidad;

        }

        public double Capacidad { get => _capacidad; set => double.TryParse(value.ToString(), out _capacidad); }

        public double Litros { get => _litros; set => double.TryParse(value.ToString(), out _litros); }
        public bool mitadCombustible { get => this.MitadCombustible; set => this.MitadCombustible = value; }
        public bool bajoCombustible { get => this.BajoCombustible; set => this.BajoCombustible = value; }
        public bool medioLleno { get => this.MedioLleno; set => this.MedioLleno = value; }
    }
}
