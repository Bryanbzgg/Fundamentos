using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Produto
    {
        //Atribulos
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }
        //Metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidade em estoque é: " + this.Estoque);
        }
    }
}
