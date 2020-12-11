using System;

namespace POO_Polimorfismo.Classes.cs
{
    public class Funcionarios
    {
        //O contador sempre começa no 0
        public string[] listas = {"Gustavo", "Luiz", "Fernando", "Jefferson", "Thiago"};

        public void Mostrar()
        {
            foreach (var item in listas)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine($"Busca por índice: "+listas[indice]);            
        }

        public void Mostrar(string busca)
        {
            foreach (var item in listas)
            {
                if(item == busca){
                    Console.WriteLine($"Resultado da busca: "+item);
                    
                }
            }
        }
    }
}