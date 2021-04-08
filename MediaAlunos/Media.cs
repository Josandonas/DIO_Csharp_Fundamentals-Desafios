using System;
namespace EstruDoPrograma.MediaAlunos{
    public class Media{
        public void media(){
            Aluno[] alunos = new Aluno[5];
            var indice = 0;
            string opcao= ObterOpcao();
            while (opcao.ToUpper() != "X"){
                switch (opcao){
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno=new Aluno();
                        aluno.Nome= Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota=nota;
                        }else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indice]=aluno;
                        indice++;
                    break;
                    case "2":
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                    break;
                    case "3":
                        decimal notaTotal=0;
                        var nrAlunos=0;
                        for(int i=0; i< alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal=notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral < 2){
                            conceitoGeral= Conceito.E;
                        }else if(mediaGeral < 4){
                            conceitoGeral= Conceito.D;
                        }else if(mediaGeral < 6){
                            conceitoGeral= Conceito.C;
                        }else if(mediaGeral < 8){
                            conceitoGeral= Conceito.B;
                        }else{
                            conceitoGeral= Conceito.A;
                        }    
                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao= ObterOpcao();
            }
        }

        private static string ObterOpcao(){
            Console.WriteLine();
            Console.WriteLine("Informe A Opção Desejada");
            Console.WriteLine("1- Inserir Novo Aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Média Geral");
            Console.WriteLine();
            String opcao = Console.ReadLine();
            return opcao;
        }
    }
}