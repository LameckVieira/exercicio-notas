using System;

namespace Exercicio_notas_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];

            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}º nome: ");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a 1º nota: ");
                nota1[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 2º nota: ");
                nota2[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 3º nota: ");
                nota3[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a 4º nota: ");
                nota4[contador] = int.Parse(Console.ReadLine());
            }
            
            for(var contador = 0; contador < 10; contador++){
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("nota: "+nota1[contador]);
                Console.WriteLine("nota: "+nota2[contador]);
                Console.WriteLine("nota: "+nota3[contador]);
                Console.WriteLine("nota: "+nota4[contador]);
            }

            float resultado = media(nota1, nota2, nota3, nota4);
            Console.WriteLine($"O valor é {resultado}");

            float  mediafinal = media(nota1, nota2, nota3, nota4);
            Console.WriteLine($"O valor é {resultado}");

            if(mediafinal){


            }


            float media(float nota1, float nota2,float nota3,float nota4){
                float media = (nota1+nota2+nota3+nota4)/4;
                Console.WriteLine($"A média do aluno é  {media}");
                return media;

            }

        }
    }
}
