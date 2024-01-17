using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSmart.Models
{
    public abstract class Smart
    {
        public Smart (string numero, string modelo, string marca, int serie)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            Serie = serie;
        }

        public string Numero { get; set; }
        protected string Modelo { get; set;}
        protected string Marca { get; set;}
        protected int Serie { get; set;}

        public abstract void ExibirMenu();

        public abstract void InstalarApp(string app);
        
    }
}