using System;
namespace TRABPOO2
{
    class Alimentacao : IOpcionais
    {
        private readonly double _precoDiario;

        public Alimentacao()
        {
            this._precoDiario = 20.00;
        }

        public double PrecoDiario => _precoDiario;
    }

    internal interface IOpcionais
    {
    }
}