using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioEscolhaCaso
{
    internal class escolhaCaso
    {
        public void escolhaCasoExercicio()

        {

            string mes;

            Console.WriteLine("Digite o número do mes: ");
            mes = Console.ReadLine();

            switch (mes)
            {
                case "1":
                    Console.WriteLine("O mês escolhido é Janeiro");
                    break;

                case "2":
                    Console.WriteLine("O mês escolhido é Fevereiro:");
                    break;

                default:
                    Console.WriteLine("O mês  solicitado é invalido");
                    break;
            }
        }
    }
 }
