namespace Celsius_to_Fahrenheit_or_Kelvin;
class Program
{
    static void CelsiusParaKelvin(double celsius){
        //convertendo para Kelvin
        double kelvin = celsius + 273.15;
        //retorne agora o número em Kelvin
        Console.WriteLine(celsius + "°C é " + kelvin + "K");
    }

    static void CelsiusParaFahrenheit(double celsius){
        //convertendo para Fahrenheit
        double fahrenheit = (celsius * 9/5) + 32;
        //retorne agora o número em Kelvin
        Console.WriteLine(celsius + "°C é " + fahrenheit + "°F");
    }
    static void Main(string[] args)
    {
        //inserindo o número
        Console.Write("digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        //direcionando para a função
        Console.WriteLine("Converter para (K)elvin ou (F)ahrenheit?");
        string opcao = Console.ReadLine();

        if (opcao.ToUpper() == "K"){
            CelsiusParaKelvin(celsius);
        }
        else if (opcao.ToUpper() == "F"){
            CelsiusParaFahrenheit(celsius);
        }
        else{
            Console.WriteLine("Opção Inválida, Digite K para Kelvin ou F para Fahrenheit!");
        }
    }
}
