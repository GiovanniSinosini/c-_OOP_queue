using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    class Paciente{

        private String nome;
        private int idade;
        private String sintomas;

        public Paciente(string nome, int idade, string sintomas)
        {
            this.nome = nome;
            this.idade = idade;
            this.sintomas = sintomas;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Sintomas { get => sintomas; set => sintomas = value; }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Idade:" + Idade + ", Sintomas: " + Sintomas;
        }
    }
}
