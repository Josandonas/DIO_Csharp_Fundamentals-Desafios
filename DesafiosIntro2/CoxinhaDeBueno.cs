using System;
namespace EstruDoPrograma.DesafiosIntro2{
    public class CoxinhaDeBueno{
        public void coxinha(){
            string[] line = Console.ReadLine().Split(" ");
            double coxinhas = int.Parse(line[0]), pessoas = int.Parse(line[1]);
            double media = coxinhas / pessoas;
            Console.WriteLine(media.ToString("N2"));
        }
    }
}