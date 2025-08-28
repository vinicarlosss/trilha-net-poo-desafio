using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (ConferePadraoNumero(numero))
            {
                Numero = numero;
            }
            else
            {
                throw new ArgumentException("Número informado é inválido, considere verificar o número digitado.");
            }
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        //Confere se o número digitado está no padrão brasileiro de números de celular
        public bool ConferePadraoNumero(string numero)
        {
            string regex = @"^\(?\d{2}\)?\s?9\d{4}-?\d{4}$";
            return Regex.IsMatch(numero, regex);
        }
    }
}