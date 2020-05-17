using System;

namespace Sistema_inventario
{
    enum TipoRecubrimiento
    {
        FENOL, HULE, POLIUTERANO
    }
    class Rueda : VehiculoComponente
    {
        public int numRuedas;
        private string recubrimiento;
        private int minDurometro;
        private int maxDurometro;

        public Rueda(int numRuedas, string recubrimiento, int minDurometro, int maxDurometrodouble)
           

        {
            NumRuedas = NumRuedas;
            Recubrimiento = recubrimiento;
            MinDurometro = minDurometro;
            MaxDurometro = maxDurometro;

        }

        public int MinDurometro { get => minDurometro; set => minDurometro = value; }
        public int MaxDurometro { get => maxDurometro; set => maxDurometro = value; }
        public int NumRuedas { get => numRuedas; set => numRuedas = value; }
        public string Recubrimiento { get => recubrimiento; set => recubrimiento = value; }
    }
}
