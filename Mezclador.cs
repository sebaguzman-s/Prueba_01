using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{
    enum TipoMezclador 
    {
        CARBURADOR, INYECTORES
    }

    class Mezclador : VehiculoComponente
    {
        public string tipo;
        public Mezclador(string tipo) 
        {
            Tipo = tipo;
        
        }

        public string Tipo { get => tipo; set => tipo = value; }
    }
}
