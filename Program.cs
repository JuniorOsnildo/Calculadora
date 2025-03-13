using Calculadora;

Boolean rodar = true;

while (rodar)
{
    Menus.MenuOpcao();

    int opcao = 0;
    
    try
    {
        opcao = int.Parse(Console.ReadLine() ?? "5");
    }
    catch
    {
        Menus.MenuOpcao();
    }

    if (opcao == 5)
    {
        Console.WriteLine("fim do programa");
        rodar = false;
    }
    else
    {
        Menus.Calculos(opcao);
    }
}

