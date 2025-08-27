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
            Numero = numero;
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
        public bool conferePadraoNumero(string numero)
        {
            string regex = @"^\(?\d{2}\)?\s?9\d{4}-?\d{4}$";
            return Regex.IsMatch(numero, regex);
        }
        //Verifica se o imei digitado tem 15 digitos como prevê os números de imei
        public bool conferePadraoImei(string imei)
        {
            string regex = @"^\d{15}$";
            return Regex.IsMatch(imei, regex);
        }
    }
}