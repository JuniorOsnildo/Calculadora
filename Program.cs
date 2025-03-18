using Calculadora;

Boolean rodar = true;

while (rodar)
{
    Menus.MenuOpcao();

    int opcao = 0;
    
    try
    {
        opcao = int.Parse(Console.ReadLine() ?? "6");
    }
    catch
    {
        Menus.MenuOpcao();
    }

    if (opcao == 6)
    {
        Console.WriteLine("fim do programa");
        rodar = false;
    }
    else
    {
        Menus.Calculos(opcao);
    }
}

