using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá sou o " + this.Nome + " minha força é de " + this.Forca + " sou atualmente nivel " + this.Nivel + "tenho uma inteligencia nivel" + this.Inteligencia + " e sou um Elfo");

        }
    }
}
