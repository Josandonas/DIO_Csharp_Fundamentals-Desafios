using System;
using System.Collections.Generic;
namespace EstruDoPrograma.DesafiosIntro3{
    public class FilaDoBanco{
        public void filaBanco(){
            int casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++) {
                if (i > 1000){
                    throw new ArgumentOutOfRangeException();
                } 

                int clientes = int.Parse(Console.ReadLine());
                
                List<int> listaDeSenhas = new List<int>();
                string[] line = Console.ReadLine().Split(" ");
                
                foreach (string item in line) {
                    if (listaDeSenhas.Count > 1000){
                        throw new ArgumentOutOfRangeException();
                    }
                    listaDeSenhas.Add(int.Parse(item));
                }
                listaDeSenhas.Sort((a, b) => b.CompareTo(a));

                int quantidade = clientes;
                for (int x = 0; x < listaDeSenhas.Count; x++) {
                    if (int.Parse(line[x]) != listaDeSenhas[x]) {
                        quantidade--;
                    }
                }
                Console.WriteLine(quantidade);
            }
        }
    }
}