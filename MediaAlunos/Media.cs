using System;
namespace EstruDoPrograma.MediaAlunos{
    public class Media{
        public void media(){
            Aluno[] alunos = new Aluno[5];
            string opcao= ObterOpcao();
            while(opcao.ToUpper() != "X"){
                switch(opcao){
                    case "1":
                    
                    break;
                    case "2":

                    break;
                    case "3":

                    break;
                    case "4":

                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}