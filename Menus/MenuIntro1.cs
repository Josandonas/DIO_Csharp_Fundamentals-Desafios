using System;
using EstruDoPrograma.DesafiosIntro1;
using EstruDoPrograma.MediaAlunos;
namespace EstruDoPrograma.Menus{
    public class MenuIntro1{
        public void Escolha1(){
            Console.Clear();
            String opcao = ObterOpcao1();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        Console.Clear();
                        var s = new Pilha();
                        for (int p = 0; p <= 5; p++){
                            s.Empilha(p);
                        }
                        for (int p = 0; p <= 5; p++){
                            Console.WriteLine(s.Desempilha());
                        }
                        break;
                    case "2":
                        Console.Clear();
                        var med = new Media();
                        med.media();
                        break;    
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\t  Digite a Quantidade: ");
                        var valor = new LacoBoasVindas();
                        int quan = Int32.Parse(Console.ReadLine());
                        valor.lacoBoas(quan);
                        break;
                    case "4":
                        Console.Clear();
                        var div = new Divisao();
                        div.dividindo();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("\t  Digite 5 Valores: ");
                        var som = new Mandiocas();
                        som.soma();
                        break;
                    case "6":
                        Console.Clear();
                        var dist = new Distancia();
                        dist.dista();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao1();
                
            }

        }

        private static String ObterOpcao1(){
            Console.WriteLine("\t\n #------------------------------------#");
            Console.WriteLine("\t\n   Digite uma das opções de execução:");
            Console.WriteLine("\t\n    1: Pilha");
            Console.WriteLine("\t\n    2: Cálclulo Da Média De Alunos");
            Console.WriteLine("\t\n    3: Laço Boas Vindas");
            Console.WriteLine("\t\n    4: Divisão Simples");
            Console.WriteLine("\t\n    5: Problema das Mandiocas");
            Console.WriteLine("\t\n    6: Problema da Distancia");
            Console.WriteLine("\t\n    X: Voltar ao Menu Anterior");
            Console.WriteLine("\t\n #------------------------------------#");

            String opcao = Console.ReadLine();
            return opcao;
        }
    }
}