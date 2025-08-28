using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Registro
    {
        List<string> numeros;

        public void AdicionarNumero(string numero)
        {
            if (numeros.Contains(numero))
            {
                throw new ArgumentException("O número informado já está vinculado a outro celular");
            }
            numeros.Add(numero);
        }
    }
}