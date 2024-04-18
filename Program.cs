while (true)
{
    Console.WriteLine("Olá, seja bem vindo à este programa inútil. Ele é super inútil, sabia? Ele serve apenas para encher linguiça neste fork. Tipo, eu nem sei o que fazer direito nisto aqui...\n Acho que vou só criar um programa com um monte de texto para encher um pouco de linguiça e então pedir para você ler esta mensagem novamente até você se cansar e encerrar o programa manualmente.... É, é isso mesmo que eu vou fazer, ou pelo menos tentar");
    Console.WriteLine("\n\nQuer continuar o programa? S/N: ");
    string FimPrograma = Console.ReadLine();
    if (FimPrograma.ToUpper() == "N") // Convertendo para maiúsculas para aceitar "S" ou "s" como resposta
    {
        Console.WriteLine("Adios!");
        break;
    }
}
