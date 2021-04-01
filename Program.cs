// Program > {} EstruDoPrograma
using System;
using EstruDoPrograma.DesafiosIntro;
namespace EstruDoPrograma{
    class Program{
         static int Main(string[] args){
            int opcao = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\t\n #------------------------------------#");
            Console.WriteLine("\t\n   Digite uma das opções de execução:");
            Console.WriteLine("\t\n    Opção 1: Pilha");
            Console.WriteLine("\t\n    Opção 2: Laço Boas Vindas");
            Console.WriteLine("\t\n    Opção 3: Divisão Simples");
            Console.WriteLine("\t\n    Opção 4: Problema das Mandiocas");
            Console.WriteLine("\t\n    Opção 5: Problema da Distancia");
            Console.WriteLine("\t\n #------------------------------------#");
            switch(opcao){
                case 1:
                    var s= new Pilha();
                    s.Empilha(1);
                    s.Empilha(10);
                    Console.WriteLine(s.Desempilha());
                    Console.WriteLine(s.Desempilha());
                break;
                case 2:
                    var valor = new LacoBoasVindas();
                    int quan = Int32.Parse(Console.ReadLine());
                    valor.lacoBoas(quan);
                break;
                case 3:
                    var div = new divisao();
                    div.dividindo();
                break;
                case 4:
                    var som = new mandiocas();
                    som.soma();
                break;
                case 5:
                    var dist = new distancia();
                    dist.dista();
                break;
            }            
            return 0; 
        }
    }
}
