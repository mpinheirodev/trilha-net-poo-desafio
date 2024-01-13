namespace DesafioPOO.Models
{
    // FEITO!!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // FEITO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
        }
    }
}