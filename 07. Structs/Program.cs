internal class Program
{
    struct Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;

        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public void exibeAnoModelo()
        {
            Console.WriteLine($" O ano do carro é {this.ano}, e o ano do modelo é {this.ano+1}");
        }
    }

    struct Pessoa
    {
        string nome;
        string identidade;
        Veiculo carro;
    }

    private static void Main(string[] args)
    {
        Veiculo carro = new Veiculo("Hyundai", "Creta", 2023);

        carro.exibeAnoModelo();

        Veiculo moto = new Veiculo();
        moto.marca = "Yamaha";
        moto.modelo = "XJ6";
        moto.ano = 2023;

        Console.ReadKey();
    }
}