using System;
using POO_Polimorfismo.Classes.cs;

namespace POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios fun = new Funcionarios();

            fun.Mostrar(0);
            fun.Mostrar("Jefferson");
            fun.Mostrar();

            Console.Beep(1000,10000);
        }
    }
}
