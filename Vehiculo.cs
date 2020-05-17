using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_inventario
{
    abstract class Vehiculo
    {
        private Motor _motor;
        private Rueda _ruedas;
        private Estanque _estanque;
        private Mezclador _mezclador;
        private VehiculoComponente _vehiculoComponente;




        public Vehiculo(int idAutomovil, string marca, string modelo,int anho, int kilometraje , int idMotor, string tipoMotor, double cilindrada,
                        int numRuedas, string tipoRecubrimiento,
                        int minDurometro, int maxDurometro, string tipomezclador,
                        double capacidad,bool MitadCombustible, bool BajoCombustible, bool MedioLleno ,double Estado)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);

            _ruedas = new Rueda(numRuedas, tipoRecubrimiento, minDurometro, maxDurometro);
            

            _estanque = new Estanque(capacidad);

            _mezclador = new Mezclador(tipomezclador);


        }

        public Rueda Ruedas { get => _ruedas; set => _ruedas = value; }

        public Estanque Estanque { get => _estanque; set => _estanque = value; }

        public Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }

        public Motor Motor { get => _motor; set => _motor = value; }
    }

}
