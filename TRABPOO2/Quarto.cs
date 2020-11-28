
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABPOO2{

  public abstract class Quarto
    {
 protected int numeroQuarto;
        protected bool disponivel;
        protected double precoBase = 35;

        protected Quarto( int numero )
        {
           this.numeroQuarto = numero; 
        }

      //  public abstract double multiplicador { get; }
        public abstract int LimiteHospedes { get; }
        public abstract double PrecoDiaria { get; }
        
        public int NumeroQuarto { get => numeroQuarto; }
        
        public abstract TipoEnum TipoQuarto { get; }

        public bool Disponivel { get => this.disponivel; }

        public string Descricao { get => this.GeraDescricao(); }
       

        protected string GeraDescricao()
        {
            // TIRAR DAQUI ?
            string descricao =  string.Format($" -- DESCRIÇÃO -- ");
            descricao += string.Format($"\nTipo do quarto: {this.TipoQuarto}");
            descricao += string.Format($"\nPreco da diaria: {this.PrecoDiaria}");
            descricao += string.Format($"\nNumero do quarto: {this.numeroQuarto}");
            descricao += string.Format($"\nDisponivel: {this.Disponivel}");
            return descricao;
        }
        public void Ocupar()
        {
            this.disponivel = false;
        }
        public void Desocupar()
        {            
            this.disponivel = true;
        }

        public abstract double CalculaPreco();

    }

    public class TipoEnum
    {
        internal static TipoEnum DUPLO;

        public static TipoEnum SIMPLES { get; internal set; }
        public static TipoEnum TRIPLO { get; internal set; }
    }
}