using System;
using EstruDoPrograma.DesafiosIntro3;
namespace EstruDoPrograma.Menus{
    public class MenuIntro3{
        public void Escolha3(){
            Console.Clear();
           String opcao = ObterOpcao3();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        Console.Clear();
                        var compra = new ComprasNoSupermercado();
                        compra.compras();
                        break;
                    case "2":
                        Console.Clear();
                        var filadBanco = new FilaDoBanco();
                        filadBanco.filaBanco();
                        break;    
                    case "3":
                        Console.Clear();
                        var validaSenha = new ValidadorDeSenhasComRequisitos();
                        validaSenha.validaSenhas();
                        break;
                    case "4":
                        Console.Clear();
                        var validaNota = new ValidaNotas();
                        validaNota.validaNotas();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao3();
                
            }

        }

        private static String ObterOpcao3(){
            Console.WriteLine("\t\n #------------------------------------#");
            Console.WriteLine("\t\n   Digite uma das opções de execução:");
            Console.WriteLine("\t\n    1: Compras no Supermercado");
            Console.WriteLine("\t\n    2: Fila do Banco");
            Console.WriteLine("\t\n    3: Validador de Senhas");
            Console.WriteLine("\t\n    4: Validador de Notas");
            Console.WriteLine("\t\n    X: Voltar ao Menu Anterior");
            Console.WriteLine("\t\n #------------------------------------#");

            String opcao = Console.ReadLine();
            return opcao;
        }
    }
}