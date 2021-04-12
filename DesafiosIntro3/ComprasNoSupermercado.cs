using System;
using System.Collections.Generic;
namespace EstruDoPrograma.DesafiosIntro3{
    public class ComprasNoSupermercado{
        public void compras(){
            int quant = int.Parse(Console.ReadLine());

            List<string> lista = new List<string>();

            for (int i = 0; i < quant; i++) {
                if (i > 100){
                    throw new ArgumentOutOfRangeException();
                } 
                string[] line = Console.ReadLine().Split(" ");

                for (int item = 0; item < line.Length; item++) {
                    if (item > 1000){
                        throw new ArgumentOutOfRangeException();
                    }else if (!lista.Contains(line[item])) {
                        lista.Add(line[item]);
                    }
                }
                        
                lista.Sort();
                Console.WriteLine(string.Join(" ", lista));
                lista.Clear();
            }
        }
    }
}