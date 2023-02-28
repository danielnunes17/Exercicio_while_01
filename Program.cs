/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

public class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Digite sua senha: ");
        int senha = int.Parse(Console.ReadLine());

        while (senha != 2002)
        {
            Console.WriteLine("Senha incorreta");
            break;
        }
        if (senha == 2002)
            Console.WriteLine("Acesso Permitido");
    }
}