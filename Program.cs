using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis para armazenar as informações de registro
        string registroEmail, registroNome, registroSenha;

        // Obtém o email, nome do usuário e senha a partir da entrada do console
        Console.WriteLine("Digite o email de registro:");
        registroEmail = Console.ReadLine();

        Console.WriteLine("Digite o nome de usuário:");
        registroNome = Console.ReadLine();

        Console.WriteLine("Digite a senha:");
        registroSenha = Console.ReadLine();

        // Constrói a mensagem de saída formatada
        string mensagemSaida = $"{registroNome}, verifique o email: {registroEmail} para ativar.";

        // Imprime a mensagem formatada
        Console.WriteLine(mensagemSaida);
    }
}