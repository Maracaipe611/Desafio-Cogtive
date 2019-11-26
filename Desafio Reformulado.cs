using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Cogtive_Reformulado
{
class Program
{
static void Main(string[] args)
{
   const string NORTE = "Norte", SUL = "Sul", OESTE = "Oeste", LESTE = "Leste";
   string Posicao = NORTE;
   int X = 0, Y = 0, comando;

      Console.WriteLine("A posição da sonda é " + X + ", " + Y + ", " + Posicao);

            Console.WriteLine("Deseja realizar qual comando?");
            Console.WriteLine("1)Girar a sonda para a direita \n2)Avançar uma casa \n3)Sair");
            comando = Convert.ToInt32(Console.ReadLine());

            while (comando != 3)
            {
                Console.Clear();

                switch (comando)
                {
                    case 1:
                        if (Posicao == NORTE)
                        {
                            Posicao = LESTE;
                        }
                        else if (Posicao == LESTE)
                        {
                            Posicao = SUL;
                        }
                        else if (Posicao == SUL)
                        {
                            Posicao = OESTE;
                        }
                        else if (Posicao == OESTE)
                        {
                            Posicao = NORTE;
                        }
                        break;
                    case 2:
                        if (Posicao == NORTE)
                        {
                            X = X + 1;
                        }
                        else if (Posicao == SUL)
                        {
                            X = X - 1;
                        }
                        else if (Posicao == LESTE)
                        {
                            Y = Y + 1;
                        }
                        else if (Posicao == OESTE)
                        {
                            Y = Y - 1;
                        }
                        break;
                }

                Console.WriteLine("A posição da sonda é " + X + ", " + Y + ", " + Posicao);
                Console.WriteLine("1)Girar a sonda para a direita \n2)Avançar uma casa \n3)Sair");
                comando = Convert.ToInt32(Console.ReadLine());

            }
}}}
