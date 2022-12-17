using System;
using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.terminada)
    {
        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab);


        Console.WriteLine();
        Console.Write("Origem: ");
        Posicao origem = Tela.lerPosicaoXandrez().toPosicao();
        Console.Write("Destino: ");
        Posicao destino = Tela.lerPosicaoXandrez().toPosicao();

        partida.executaMovimento(origem,destino);

    }
    

   
}
catch( TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();