/// 2) Elabore um programa em C# que gerencie o acesso de convidados a partir
/// de um vetor fixo de nomes (string[] convidadosVip = { "Ana Silva", "Carlos Souza", "Mariana Costa" };). O programa deve solicitar que 
/// o usuário digite o número do crachá (o índice) correspondente. Como o usuário pode digitar coisas inesperadas, o código deve estar totalmente
/// protegido utilizando a estrutura try...catch com três blocos de tratamento (O que pode dar errado nesse caso deve ser capturado). Um deve ser genérico

string[] convidadosVip = { "Ana silva", "Carlos Souza", "Mariana Costa" };

try
{
    Console.Write("Digite o número do seu crachá: ");
    int num = int.Parse(Console.ReadLine());


    string convidado = convidadosVip[num];

    Console.WriteLine($"Acesso liberado {convidado}");




}


catch (IndexOutOfRangeException)
{
    Console.WriteLine("Número não encontrado no sistema, tente novamente!");
}


catch(FormatException) {
    Console.WriteLine("Digite apenas números, tente novamente");


}

catch (Exception ex)
{
    Console.WriteLine($"ERRO, tente novamente mais tarde: {ex.Message}");


}