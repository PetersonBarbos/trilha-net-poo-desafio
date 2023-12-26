namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        private string imei;
        private int memoria;
        public Smartphone(string numero, string modelo1, string imei1, int memoria1)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            modelo = modelo1;
            imei = imei1;
            memoria = memoria1;
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
    }
}