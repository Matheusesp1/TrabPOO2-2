using System;
namespace TRABPOO2
{
    public class Reserva
    {
      public string Tipo_Acomod;   
      public DateTime Data_entrada;   
      public DateTime Data_Saida;
      public string Cliente;  
      public string Pagamento;
    }

    public void GetData_entrada(bool Data_entrada) => Console.WriteLine(value: Data_entrada);

    public void GetData_Saida()
    {
        var Data_Saida = false;
        Console.WriteLine(value: Data_Saida);
    }
}




