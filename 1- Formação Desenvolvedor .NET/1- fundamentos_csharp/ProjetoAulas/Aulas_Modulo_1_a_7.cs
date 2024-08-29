// Console.WriteLine("Hello, World!");


// ---------------------------------------------

// int idade = 33;
// Console.WriteLine(idade);

// ---------------------------------------------

// string nomePessoa = "Lucas";
// Console.WriteLine(nomePessoa);

// ---------------------------------------------

// decimal valor = 200.99m;
// double valorDouble = 200.99;
// float valorFloat = 200.99f;

// ---------------------------------------------

// const string derscricao = "Curso CSHARP";
// // derscricao = "curso";
// Console.WriteLine(derscricao);

// ---------------------------------------------

// EscreverNome();

// string NomeCompleto()
// {
//     string primeiroNome = "Lucas";
//     string segundoNome = "Rubo";
//     return primeiroNome + " " + segundoNome;
// }

// int SomaValores(int valor1, int valor2)
// {
//     return valor1 + valor2;
// }

// void EscreverNome()
// {
//     var nome = NomeCompleto();
//     Console.WriteLine(nome);
//     Console.WriteLine(SomaValores(1, 2));
// }

// ---------------------------------------------

using System.Collections;

// var arrayList = new ArrayList();
// arrayList.Add(1);
// arrayList.Add("Rafael");
// arrayList.Add(true);

// ---------------------------------------------

// Console.WriteLine(arrayList[0]);
// arrayList.Remove(1);
// arrayList.Clear();
// foreach (var item in arrayList)
// {
//     Console.WriteLine(item);
// }

// ---------------------------------------------

// var arrayTpadoNumero = new int[3] { 1, 2, 3 };
// Array.Resize(ref arrayTpadoNumero, 100);
// arrayTpadoNumero[2] = 10;
// foreach (var item in arrayTpadoNumero)
// {
//     Console.WriteLine(item);
// }

// ---------------------------------------------

// var lista = new List<string>(10);
// lista.Add("Lucas");
// lista.Add("Larissa");
// lista.Add("Rafael");

// ---------------------------------------------

// var dicionario = new Dictionary<string, string>();
// dicionario.Add("nome", "Lucas");
// dicionario.Add("idade", "33");
// dicionario.Add("profissao", "Programador");

// var nome = dicionario["nome"];
// var profissao = dicionario["profissao"];

// Console.WriteLine($"{nome} {profissao}");

// ---------------------------------------------

// var queue = new Queue<string>();
// queue.Enqueue("Lucas");
// queue.Enqueue("Larissa");
// queue.Enqueue("Rafael");

// var nome = queue.Peek();
// Console.WriteLine(nome);
// var nome1 = queue.Dequeue();
// Console.WriteLine(nome1);
// var nome2 = queue.Dequeue();
// Console.WriteLine(nome2);

// foreach (var item in queue)
// {
//     Console.WriteLine(item);
// }

// ---------------------------------------------

// var stack = new Stack<string>();
// stack.Push("Lucas");
// stack.Push("Larissa");
// stack.Push("Rafael");

// var nome = stack.Pop();
// Console.WriteLine(nome);

// foreach (var item in stack)
// {
//     Console.WriteLine(item);
// }