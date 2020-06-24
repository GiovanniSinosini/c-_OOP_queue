using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Urgencias urgencia1 = new Urgencias();

            urgencia1.regPaciente("User1", 19, "Excesso de espirulina");
            urgencia1.regPaciente("User2", 20, "Gripe");
            urgencia1.regPaciente("User3", 22, "Covid");
            urgencia1.regPaciente("User4", 23, "Febre");
            urgencia1.regPaciente("User5", 15, "Dor barriga");

            Console.WriteLine("Fila de espera:");
            urgencia1.imprimirFila();

            Console.WriteLine();
                        
            urgencia1.atendPaciente("User1", 19, "Excesso de espirulina");
            urgencia1.atendPaciente("User2", 20, "Gripe");

            Console.WriteLine("Fila de espera atualizada");
            urgencia1.imprimirFila();

            Console.WriteLine();
            Console.WriteLine("Próximo Paciente a ser atendido:");
            Console.WriteLine(urgencia1.proxPaciente());
        }
    }
}
