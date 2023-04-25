using System;

namespace ModificadoresDeAcesso
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            Console.WriteLine("Hello World");
        }
        // private classe fica privada
        // , protected apenas itens filho ou seja que herda do pai consegue acessa
        // , internal 
        // e public base.  Para usar henrença
        public class Pagamento
        {   // Propriedades
            DateTime Vencimento;
            // Métodos
            void Pagar() { }
        }
    }
}