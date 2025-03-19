using System.Runtime.CompilerServices;

namespace Calculadora;

public class Sistema
{
    private static LinkedList<String> historico = [];
    
    public static void Somar(float numero1, float numero2)
    {
        float resultado = numero1 + numero2;
        String texto = numero1 + " + " + numero2 + " = "  + Math.Round(resultado, 2);
        Console.WriteLine(texto);
        historico.AddLast(texto);
    }
    
    public static void Sub(float numero1, float numero2)
    {
        float resultado = numero1 - numero2;
        String texto = numero1 + " - " + numero2 + " = "  + Math.Round(resultado, 2);
        Console.WriteLine(texto);
        historico.AddLast(texto);
    }
    
    public static void Mult(float numero1, float numero2)
    {
        float resultado = numero1 * numero2;
        String texto = numero1 + " * " + numero2 + " = "  + Math.Round(resultado, 2);
        Console.WriteLine(texto);
        historico.AddLast(texto);
    }
    
    public static void Div(float numero1, float numero2)
    {
        if (numero1 != 0)
        {
            float resultado = numero1 / numero2;
            String texto = numero1 + " / " + numero2 + " = "  + Math.Round(resultado, 2);
            Console.WriteLine(texto);
            historico.AddLast(texto);
        }
        else
        {
            Console.WriteLine("Divisão por zero não é permitida");
        }
        
    }

    public static void Tabuada(float numero)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i + " X " + numero + " = " + Math.Round(numero*i, 2) );
        }
    }

    public static void MostrarHistorico()
    {
        foreach (var s in historico)
        {
            Console.WriteLine(s);
        }
    }
    
}