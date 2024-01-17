using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSmart.Models
{
    public class Iphone : Smart 
    {

         public Iphone (string numero, string modelo, string marca, int serie) :base(numero,modelo,marca,serie){}
              
           public override void ExibirMenu()
        {
           
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Serie: {Serie}");

        }

        public override void InstalarApp(string app)
        {
             Console.WriteLine($"instalando o app {app}");
        }
    }
}