using System;
namespace TRABPOO2
{
    public class Pagamento
    {
        private ValueType pagar;

        public ValueType Pagar { get => pagar; set => pagar = value; }

        public override bool Equals(object obj)
        {
            return obj is Pagamento pagamento &&
                   System.Collections.Generic.EqualityComparer<ValueType>.Default.Equals(Pagar, pagamento.Pagar);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Pagar);
        }
    }
}