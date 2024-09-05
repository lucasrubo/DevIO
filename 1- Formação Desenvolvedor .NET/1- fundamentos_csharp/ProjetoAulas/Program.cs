using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            TrabalhandoComLinq();
        }

        private static void TrabalhandoComLinq()
        {
            var linq = new Modulo14.TrabalhandoComLinq();
            // linq.AulaWhere();
            // linq.AulaOrdenacao();
            // linq.AulaTake();
            linq.AulaFirst();
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }
        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "C#" };
            // var curso2 = new Cadastro.Curso { Id = 2, Descricao = "Java" };
            // var curso3 = new Cadastro.Curso { Id = 2, Descricao = "Java" };

            // var curso1 = new Cadastro.Curso(1, "C#");
            // var curso2 = new Cadastro.Curso(2, "Java");
            // var curso3 = new Cadastro.Curso(2, "Java");

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "C#" };
            // var curso2 = curso1;

            // var curso2 = new Cadastro.CursoTeste();
            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Java";

            var curso1 = new Cadastro.Curso(1, "C#");
            var curso2 = curso1 with { Descricao = "Java" };

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);

            // Console.WriteLine(curso1 == curso2);
            // Console.WriteLine(curso2.Equals(curso3));
            // Console.WriteLine(curso2 == curso3);
        }
        private static void AulaClasseAbtract()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.ImprimirDados();
        }
        private static void AulaSealed()
        {
            // var configuracao = new Cadastro.Configuracao();
            // configuracao.Host = "localhost";
            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };
            Console.WriteLine(configuracao.Host);
        }
        private static void AulaHeranca()
        {
            // var pessoaFisica = new Cadastro.PessoaFisica();
            // pessoaFisica.Id = 1;
            // pessoaFisica.CPF = "123456789";
            // pessoaFisica.Endereco = "Rua 1";
            // pessoaFisica.Cidade = "São Paulo";
            // pessoaFisica.Cep = "12345-678";
            // pessoaFisica.ImprimirDados();
            // pessoaFisica.ImprimirCpf();


            var Funcionario = new Cadastro.Funcionario();
            Funcionario.Id = 1;
            Funcionario.CPF = "123456789";
            Funcionario.Endereco = "Rua 1";
            Funcionario.Cidade = "São Paulo";
            Funcionario.Cep = "12345-678";
            Funcionario.ImprimirDados();
            Funcionario.ImprimirCpf();
        }
        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "mouse";
            // produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(1, 2);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado";
            produto.ImprimirDescricao();
        }
    }
}