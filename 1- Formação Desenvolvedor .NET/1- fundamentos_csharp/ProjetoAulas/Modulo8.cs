using System.Data.Common;
using System.Security.AccessControl;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }
    public class Produto
    {
        public string Descricao { get; set; }
        // public readonly int Estoque;
        public int Estoque { get; }
        private int Id { get; set; }

        public Produto()
        {
            Estoque = 1;
        }
        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + ": " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }

    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("Cpf: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInfo();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Info:" + GetInfo());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInfo()
        {
            return "Cachorro é um bom amigo";
        }
    }

    // public record Curso
    // {
    //     public int Id { get; set; }
    //     public string Descricao { get; set; }

    //     // public override bool Equals(object? obj)
    //     // {
    //     //     if (obj == null) return false;

    //     //     if (obj is Curso curso)
    //     //     {
    //     //         return Id == curso.Id && Descricao == curso.Descricao;
    //     //     }
    //     //     return base.Equals(obj);
    //     // }
    //     // public static bool operator ==(Curso a, Curso b)
    //     // {
    //     //     return a.Equals(b);
    //     // }
    //     // public static bool operator !=(Curso a, Curso b)
    //     // {
    //     //     return !(a == b);
    //     // }
    // }

    public record Curso(int Id, string Descricao);
    public record CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificacao Cliente");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificacao Outros");
        }
    }
    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificacao Funcionario");
        }
        public void NotificarOutros()
        {
            Console.WriteLine("Notificacao Outros");
        }
    }
}