using System;
using EstruDoPrograma.DesafiosIntro2;

namespace EstruDoPrograma.Menus{
    public class MenuIntro2{
        public void Escolha2(){
            Console.Clear();
           String opcao = ObterOpcao2();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        Console.Clear();
                        var bazinga = new Bazinga();
                        bazinga.bazing();
                        break;
                    case "2":
                        Console.Clear();
                        var coxa = new CoxinhaDeBueno();
                        coxa.coxinha();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao2();
                
            }
        }
        private static String ObterOpcao2(){
                Console.WriteLine("\t\n #------------------------------------#");
                Console.WriteLine("\t\n   Digite uma das opções de execução:");
                Console.WriteLine("\t\n    1: Bazinga!!");
                Console.WriteLine("\t\n    2: Coxinhas de Bueno");
                Console.WriteLine("\t\n    X: Voltar ao Menu Anterior");
                Console.WriteLine("\t\n #------------------------------------#");

                String opcao = Console.ReadLine();
                return opcao;
        }   
    }
}