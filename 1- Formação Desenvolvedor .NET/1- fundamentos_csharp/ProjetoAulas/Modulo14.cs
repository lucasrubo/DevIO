namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaFirst()
    {
        var numeros = new int[] { 10, 20, 3, 4, 5, 7, 8, 1 };
        // var resultado = numeros.First();
        // var resultado = numeros.First(p => p > 15);
        var resultado = numeros.FirstOrDefault();

        Console.WriteLine(resultado);

    }
    public void AulaTake()
    {
        var numeros = new int[] { 10, 20, 3, 4, 5, 7, 8, 1 };
        var resultado = numeros.Where(x => x > 10).Take(3).OrderBy(p => p);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
    public void AulaOrdenacao()
    {
        var numeros = new int[] { 10, 20, 3, 4, 5, 7, 8, 1 };
        // var resultado = numeros.OrderBy(p => p);
        var resultado = numeros.OrderByDescending(p => p);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
    public void AulaWhere()
    {
        // string nomeCompleto = "lucas rubo";

        // Func<char, bool> filtro = x => x == 'u';

        // var resultado = from c in nomeCompleto where c == 'u' select c;

        // var resultado = nomeCompleto.Where(filtro);

        // var resultado = nomeCompleto.Where(x => x == 'u');
        // Console.WriteLine(string.Join("-", resultado));

        // foreach (var letra in resultado)
        // {
        //     Console.WriteLine(letra);
        // }

        var numeros = new int[] { 10, 20, 3, 4, 5, 7, 8, 1 };
        var resultado = from n in numeros where n >= 5 select n;
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
}