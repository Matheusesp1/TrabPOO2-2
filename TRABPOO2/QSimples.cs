using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TRABPOO2
{
    public class QuartoSimples : Quarto
    {

        private TipoEnum _tipoQuarto;
        private int _limiteHospedes;
        private double _multiplicador;
        private double _precoDiaria;
        //private List<Hospede> _hospedes;

        public QuartoSimples(int numero) : base(numero)
        {
            this._tipoQuarto = TipoEnum.SIMPLES;
            this._limiteHospedes = 1;
            this._multiplicador = 1.8;
            this._precoDiaria = CalculaPreco();
            //_hospedes = new List<Hospede>();
        }

        public override TipoEnum TipoQuarto => _tipoQuarto;
        public override int LimiteHospedes => _limiteHospedes;
        public override double PrecoDiaria => _precoDiaria;

        //public override List<Hospede> Hospedes => _hospedes;

      //  public override double multiplicador => _multiplicador;
        
        public override double CalculaPreco()
        {
            return precoBase * _multiplicador;
        }
    }
}