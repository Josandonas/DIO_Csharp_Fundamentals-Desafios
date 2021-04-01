// Program > {} EstruDoPrograma
using System;
using EstruDoPrograma.Exemplos;
namespace EstruDoPrograma{
    class Program{
         void Main(string[] args){
            var s= new Pilha();
            var valor = new LacoBoasVindas();
            var div = new divisao();
            var som = new mandiocas();
            var dist = new distancia();

            div.dividindo();
            valor.lacoBoas(3);
            
            s.Empilha(1);
            s.Empilha(10);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());

            som.soma();
            dist.dista();
        }
    }
}
