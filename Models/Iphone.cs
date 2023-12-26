namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo1, string imei1, int memoria1): base(numero, modelo1, imei1, memoria1)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando {nomeApp} no Iphone");
        }
    }
}