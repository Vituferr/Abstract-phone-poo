namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (Memoria <= 1)
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
            }
            else
            {
                throw new InvalidOperationException("Memória insuficiente para instalar o aplicativo.");
            }
        }
    }
}