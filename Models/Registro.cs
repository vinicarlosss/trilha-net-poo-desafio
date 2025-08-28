using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Registro
    {
        List<string> numeros = new List<string>();

        public void AdicionarNumero(string numero)
        {
            if (numeros.Contains(numero))
            {
                throw new ArgumentException("O número informado já está vinculado a outro aparelho");
            }
            numeros.Add(numero);
        }
    }
}