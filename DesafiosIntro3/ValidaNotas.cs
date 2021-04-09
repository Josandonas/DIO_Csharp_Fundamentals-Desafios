using System;
namespace EstruDoPrograma.DesafiosIntro3{
    public class ValidaNotas{
        public void validaNotas(){
            double somaNotas=0;
            bool op;
            int count=0;
            while(count < 2){
                op=true;
                double nota=double.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10){
                    Console.WriteLine("nota invalida");
                }else if(count == 0 ){
                    somaNotas =nota;
                    count++;
                }else if(count == 1){
                    double media=somaNotas+nota;
                    Console.WriteLine("media = "+(media/2).ToString("N2"));                            
                    while(op == true){
                        Console.WriteLine("novo calculo (1-sim 2-nao)");                    
                        double resposta= double.Parse(Console.ReadLine());
                        if(resposta == 1){
                            op=false;
                            count=0;
                        }else if(resposta == 2){
                            op=false;
                            count++;
                        }
                    }
                }
            }
        }
    }
}