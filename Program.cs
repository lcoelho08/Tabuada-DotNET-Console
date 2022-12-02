


using Tabuada_DotNET.Models;

Tabuada tab = new Tabuada();
Tabuada exibirMenu = new Tabuada();

exibirMenu.ExibirMenu();


//tab.Adicao();

while(true)
{
    switch (Console.ReadLine())
    {
        
        case "1":
            tab.Adicao();
            break;

        case "2":
            tab.Multiplicacao();
            
            break;

        case "3":
            tab.Subtracao();
            break;

        case "4":
            tab.Divisao();
            break;

        case "5":
            Console.WriteLine("Programa encerrado");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção invalida, escolha novamente");
            exibirMenu.ExibirMenu();
            break;
    }
}
