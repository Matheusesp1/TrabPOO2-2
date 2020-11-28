using System;
namespace TRABPOO2
{
 
    public class Cliente
    {
        public Cliente(string nome_cliente, string end_lugar, int num_telefone, string end_bairro, string end_cidade, DateTime data_nascimento, string rG)
        {
            this.nome_cliente = nome_cliente;
            this.end_lugar = end_lugar;
            this.num_telefone = num_telefone;
            this.end_bairro = end_bairro;
            this.end_cidade = end_cidade;
            this.data_nascimento = data_nascimento;
            RG = rG;
        }

        public string nome_cliente
        {
            get;
            set;
        }

        public string end_lugar
        {
            get;
            set;
        }


        public int num_telefone
        {
            get;
            set;
        }

        public string end_bairro
        {
            get;
            set;
        }


        public string end_cidade
        {
            get;
            set;
        }

        public DateTime data_nascimento

        {
            get;
            set;
        }

        public string RG
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }






}

