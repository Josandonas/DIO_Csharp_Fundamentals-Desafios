// Program > {} EstruDoPrograma
using System;
using EstruDoPrograma.Exemplos;
namespace EstruDoPrograma{
    class Program{
        static void Main(string[] args){
            var s= new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            var valor= new LacoBoasVindas();
            valor.lacoBoas(7);
        }
    }
}
