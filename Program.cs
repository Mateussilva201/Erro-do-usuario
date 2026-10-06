


using System.ComponentModel.Design;
using System.Linq.Expressions;

/// 1) Elabore um programa em C# que solicite ao usuário que digite a sua idade.
/// O programa deve usar o comando int.TryParse apenas uma vez (sem loops) para validar a entrada. 
/// Se o usuário digitar um número inteiro válido, o programa deve exibir uma mensagem de sucesso mostrando a idade. 
/// Se o usuário digitar letras ou símbolos inválidos, o programa deve exibir uma mensagem de erro educada, sem fechar ou quebrar a aplicação

bool continuar = true;

do
{
    Console.Write("Digite sua idade: ");
    string entrada = Console.ReadLine();


    if (int.TryParse(entrada, out int idade))
    {
        Console.WriteLine($"Você tem {idade} anos");

    }


    else
    {
        Console.WriteLine("Erro de sintaxe, tente novamente");
    }

        Console.Write("Quer tentar novamente? S/N: ");
        string tentativa = Console.ReadLine().ToUpper();

        if (tentativa == "N")
        {
            continuar = false;
        }

} while (continuar);

Console.Clear();

Console.WriteLine("Digite qualquer tecla para sair...");

