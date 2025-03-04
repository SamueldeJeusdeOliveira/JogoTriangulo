using System.Security.Cryptography.X509Certificates;

namespace JogoTriangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
                while (resposta != 2)
                {
                    Console.WriteLine($"\nMENU: "
                        + "\nTECLE E DIGITE O NÙMERO E APERTE O ENTER NA ALTERNATIVA QUE DESEJA\n"
                        + "1 - Verificar um novo triângulo\n"
                        + "2 - Sair do Jogo\n");
                resposta = int.Parse(Console.ReadLine());
                    if (resposta == 2)
                    {
                    break;
                    }
                    try
                    {
                        Console.Write("Digite o valor x do triângulo(è permitido neste jogo apenas nùmeros inteiros): ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor y do triângulo(è permitido neste jogo apenas nùmeros inteiros): ");
                        int y = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor z do triângulo(è permitido neste jogo apenas nùmeros inteiros): ");
                        int z = int.Parse(Console.ReadLine());

                        Formula(x, y, z);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Houve um erro no sitema, o jogador não digitou corretamente os valores");
                        Console.WriteLine(e.Message);
                    }
                }
            Console.WriteLine("Você saiu do jogo!\nVolte sempre!");
            void Formula(int x, int y, int z)
            {
                if (x <= 0 || y <= 0 || z <= 0)
                {
                    Console.WriteLine("Os lados do triângulo devem ser números positivos!");
                    return;
                }

                if (!(x + y > z && x + z > y && y + z > x))
                {
                    Console.WriteLine("Triângulo invàlido!");
                    Console.WriteLine("A soma dos dois lados não pode ser maior do que o terceiro lado!");
                    return;

                }
                if (x != y && y != z && x != z)
                {
                    Console.WriteLine("Seu triândulo é escaleno");
                }
                else if (x == y && y == z)
                {
                    Console.WriteLine("Seu triângulo é equilátero");
                }
                else
                {
                    Console.WriteLine("Seu Triângulo é isóceles");
                }
            }
        }
    }
}