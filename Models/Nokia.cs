namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo1, string imei1, int memoria1): base(numero, modelo1, imei1, memoria1)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando {nomeApp} no Nokia");
        }
    }
}