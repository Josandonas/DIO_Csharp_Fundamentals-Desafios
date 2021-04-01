// Desafio
// Você terá o desafio de escrever um algoritmo que leia 2
// números e imprima o resultado da divisão do primeiro pelo segundo.
// Caso não for possível, mostre a mensagem “divisao impossivel” para
// os valores em questão.
using System;
namespace EstruDoPrograma.Exemplos{
    public class divisao{
        public void dividindo(){
                int limit = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < limit; i++){
                    string[] line = Console.ReadLine().Split(" ");
                    double X = double.Parse(line[0]),Y = double.Parse(line[1]);
                    
                    if (Y == 0){
                        Console.WriteLine("divisao impossivel");
                    }else{

                        double divisao = (X / Y); // Digite aqui o calculo da divisao
                        if (divisao < 0 && (divisao.ToString("N1") == "0.0"))
                            Console.WriteLine("-0.0");
                        else
                            Console.WriteLine(divisao.ToString("N1"));
                    }
                }
        }
    }
}