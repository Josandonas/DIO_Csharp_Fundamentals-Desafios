using System;
namespace EstruDoPrograma.Exemplos
{
    public class mandiocas
    {
        public void soma() {
        var chico = 300 * Int32.Parse(Console.ReadLine());
        var bento = 1500 * Int32.Parse(Console.ReadLine());
        var bernardo = 600 * Int32.Parse(Console.ReadLine());
        var marina = 1000 * Int32.Parse(Console.ReadLine());
        var iara = 150 * Int32.Parse(Console.ReadLine());
        var marlene = 225;
        var total = chico+bento+bernardo+marina+iara+marlene; // Digite aqui o calculo total
        Console.WriteLine(total);
    }
    }
}