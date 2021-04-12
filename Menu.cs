using System;
using EstruDoPrograma.Menus;

namespace EstruDoPrograma.Menu{
    public class Menu{
        public void Escolha(){
            Console.Clear();
            String opcao = ObterOpcao();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        Console.Clear();
                        var decisao1= new Menus.MenuIntro1();
                        decisao1.Escolha1();
                        break;
                    case "2":
                        Console.Clear();
                        var decisao2= new Menus.MenuIntro2();
                        decisao2.Escolha2();
                        break;    
                    case "3":
                        Console.Clear();
                        var decisao3= new Menus.MenuIntro3();
                        decisao3.Escolha3();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao();
                
            }

        }

        private static String ObterOpcao(){
            Console.Clear();
            Console.WriteLine("\t\n #------------------------------------#");
            Console.WriteLine("\t\n   Digite uma das opções de execução:");
            Console.WriteLine("\t\n    1: Introdução aos Desafios 1");
            Console.WriteLine("\t\n    2: Introdução aos Desafios 2");
            Console.WriteLine("\t\n    3: Introdução aos Desafios 3");
            Console.WriteLine("\t\n    X: Encerrar Programa");
            Console.WriteLine("\t\n #------------------------------------#");

            String opcao = Console.ReadLine();
            return opcao;
        }
    }
}