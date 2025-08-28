using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria, Registro registro)
        {
            if (ConferePadraoNumero(numero))
            {
                Numero = numero;
                registro.AdicionarNumero(numero);
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

            string ddd = numero.Substring(0, 2);
            if (ConfereDDD(ddd))
            {
                string regex = @"^\(?\d{2}\)?\s?9\d{4}-?\d{4}$";
                return Regex.IsMatch(numero, regex);
            }
            throw new ArgumentException("O DDD informado não existe. Considere verificar o número digitado.");
        }
        //Confere se o DDD digitado é válido
        public bool ConfereDDD(string ddd)
        {

            List<string> ddds = new List<string>
        {
            "11", "12", "13", "14", "15", "16", "17", "18", "19", // SP
            "21", "22", "24",                                     // RJ
            "27", "28",                                           // ES
            "31", "32", "33", "34", "35", "37", "38",             // MG
            "41", "42", "43", "44", "45", "46",                   // PR
            "47", "48", "49",                                     // SC
            "51", "53", "54", "55",                               // RS
            "61",                                                 // DF
            "62", "64",                                           // GO
            "63",                                                 // TO
            "65", "66",                                           // MT
            "67",                                                 // MS
            "68",                                                 // AC
            "69",                                                 // RO
            "71", "73", "74", "75", "77",                         // BA
            "79",                                                 // SE
            "81", "87",                                           // PE
            "82",                                                 // AL
            "83",                                                 // PB
            "84",                                                 // RN
            "85", "88",                                           // CE
            "86", "89",                                           // PI
            "91", "93", "94",                                     // PA
            "92", "97",                                           // AM
            "95",                                                 // RR
            "96",                                                 // AP
            "98", "99"                                            // MA
        };
            return ddds.Contains(ddd);
        }
    }
}
