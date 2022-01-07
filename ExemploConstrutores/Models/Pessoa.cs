using System;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;

        // public Pessoa()// exemplo de construtor da classe Pessoa SEM parâmetro;
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome)// exemplo de construtor da classe Pessoa COM parâmetro;
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é {nome} {sobrenome}");
        }
    }
}