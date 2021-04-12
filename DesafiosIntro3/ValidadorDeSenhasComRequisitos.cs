using System;
using System.Text.RegularExpressions;
namespace EstruDoPrograma.DesafiosIntro3{
    public class ValidadorDeSenhasComRequisitos{
        public void validaSenhas(){
            while (true) {
                string senha = Console.ReadLine();
                if (string.IsNullOrEmpty(senha)){
                    throw new ArgumentOutOfRangeException();
                } 
                Regex formato = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,32}$");
                Match senhaPerfeita = formato.Match(senha);
                
                if (senhaPerfeita.Success) {
                    Console.WriteLine("Senha valida.");
                } else {
                    Console.WriteLine("Senha invalida.");
                }
            } 
        }
    }
}