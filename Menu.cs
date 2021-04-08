using System;
using EstruDoPrograma.DesafiosIntro1;
using EstruDoPrograma.DesafiosIntro2;
using EstruDoPrograma.MediaAlunos;

namespace EstruDoPrograma.Menu{
    public class Menu{
        public void Escolha(){
            String opcao = ObterOpcao();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        var s = new Pilha();
                        for (int p = 0; p <= 5; p++){
                            s.Empilha(p);
                        }
                        for (int p = 0; p <= 5; p++){
                            Console.WriteLine(s.Desempilha());
                        }
                        break;
                    case "2":
                        var med = new Media();
                        med.media();
                        break;    
                    case "3":
                        var valor = new LacoBoasVindas();
                        int quan = Int32.Parse(Console.ReadLine());
                        valor.lacoBoas(quan);
                        break;
                    case "4":
                        var div = new Divisao();
                        div.dividindo();
                        break;
                    case "5":
                        Console.WriteLine("\t  Digite 5 Valores: ");
                        var som = new Mandiocas();
                        som.soma();
                        break;
                    case "6":
                        var dist = new Distancia();
                        dist.dista();
                        break;
                    case "7":
                        var bazi = new Bazinga();
                        bazi.bazing();
                        break;
                    case "8":
                        var coxa = new CoxinhaDeBueno();
                        coxa.coxinha();
                        break;                                                
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao();
                
            }

        }

        private static String ObterOpcao(){
            Console.WriteLine("\t\n #------------------------------------#");
            Console.WriteLine("\t\n   Digite uma das opções de execução:");
            Console.WriteLine("\t\n    1: Pilha");
            Console.WriteLine("\t\n    2: Cálclulo Da Média");
            Console.WriteLine("\t\n    3: Laço Boas Vindas");
            Console.WriteLine("\t\n    4: Divisão Simples");
            Console.WriteLine("\t\n    5: Problema das Mandiocas");
            Console.WriteLine("\t\n    6: Problema da Distancia");
            Console.WriteLine("\t\n    7: Bazinga!");
            Console.WriteLine("\t\n    8: Coxinhas de Bueno");
            Console.WriteLine("\t\n    X: Encerrar Programa");
            Console.WriteLine("\t\n #------------------------------------#");

            String opcao = Console.ReadLine();
            return opcao;
        }
    }
}