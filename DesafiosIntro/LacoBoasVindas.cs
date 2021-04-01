using System;
namespace EstruDoPrograma.DesafiosIntro{
    public class LacoBoasVindas{
      public void lacoBoas(int quantidade){
        for(int i=0; i <= quantidade ; i++){
            Console.WriteLine($"Bem-Vindo ao curso de .NET {i}");
        }  
      }
    }
}