using System;
using System.Collections.Generic;
using System.Text;

namespace Teste
{
    class Urgencias{

        Queue<Paciente> paciente;

        public Urgencias(){
            paciente = new Queue<Paciente>();
        }

        public bool regPaciente(string nom, int i, string sint)
        {
            paciente.Enqueue(new Paciente(nom, i, sint));
            return true;
        }
        
        public bool atendPaciente(string nom, int i, string sint){
            
            if (paciente.Count != 0){

                paciente.Dequeue();
                return true;
            }

            return false;
        }

        public String proxPaciente()
        {
          return paciente.Peek().ToString();
                    
        }

        public void imprimirFila()
        {           
            foreach (var item in paciente)
            {
                Console.WriteLine(item.Nome + ", " + item.Idade + ", " + item.Sintomas + ".");
            }
        }
    }
}
