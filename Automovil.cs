using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{
    class Automovil : Vehiculo
    {
        private int _idAutomovil;
        private String _marca;
        private String _modelo;
        private int _anho;
        private int _kilometraje;
        
        public string Marca { get => _marca; set => _marca = value; }
        public int Anho { get => _anho; set => _anho = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int IdAutomovil { get => _idAutomovil; set => _idAutomovil = value; }

        public Automovil(int IdAutomovil ,string Marca,string Modelo, int Anho,int Kilometraje, int idMotor, string tipoMotor, double cilindrada, int numRuedas,
                        string tipoRecubrimiento, int minDurometro, int maxDurometro, string tipoMezclador, double capacidad, bool MitadCombustible, bool BajoCombustible, bool MedioLleno, double estado)
                        : base(IdAutomovil ,Marca,Modelo , Anho, Kilometraje, idMotor, tipoMotor, cilindrada, numRuedas, tipoRecubrimiento, minDurometro, maxDurometro,
                              tipoMezclador, capacidad, MitadCombustible, BajoCombustible,MedioLleno, estado)
        {
        }

        
    }
        
}

