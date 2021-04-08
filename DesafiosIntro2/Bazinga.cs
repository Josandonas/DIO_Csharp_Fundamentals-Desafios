using System;
namespace EstruDoPrograma.DesafiosIntro2{
    public class Bazinga{
        public void bazing(){
            int limit = int.Parse(Console.ReadLine());
            if(limit <= 100){
                for (int i = 1; i <= limit; i++) {
                    string[] line = Console.ReadLine().Split(" ");
                    string sheldon = line[0].ToLower();
                    string raj = line[1].ToLower();
                    if(sheldon == "pedra" && raj == "lagarto" || sheldon == "pedra" && raj == "tesoura" 
                    || sheldon == "tesoura" && raj == "papel" || sheldon == "tesoura" && raj == "lagarto" 
                    || sheldon == "papel" && raj == "pedra" || sheldon == "papel" && raj == "spock"
                    || sheldon == "lagarto" && raj == "spock" || sheldon == "lagarto" && raj == "papel"
                    || sheldon == "spock" && raj == "tesoura" || sheldon == "spock" && raj == "pedra"){
                         Console.WriteLine("Caso #" + i + ": Bazinga!");
                    }else if(sheldon == "lagarto" && raj == "pedra" || sheldon == "tesoura" && raj == "pedra" 
                    || sheldon == "papel" && raj == "tesoura" || sheldon == "lagarto" && raj == "tesoura" 
                    || sheldon == "pedra" && raj == "papel" || sheldon == "spock" && raj == "papel"
                    || sheldon == "spock" && raj == "lagarto" || sheldon == "papel" && raj == "lagarto"
                    || sheldon == "tesoura" && raj == "spock" || sheldon == "pedra" && raj == "spock"){
                        Console.WriteLine("Caso #" + i + ": Raj trapaceou!");
                    }else{
                       Console.WriteLine("Caso #" + i + ": De novo!"); 
                    }
                }
            }else{
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
// tesoura corta papel, tesoura decapita lagarto

// papel emburlha pedra, papel contesta spock

// pedra esmaga lagarto, pedra quebra tesoura

// lagarto envenena spock, lagarto come papel
 
// Spock destroi tesoura, Spock vaporiza a pedra


// T P - T L tesoura ganha
// P P - P S papel ganha
// P L - P T pedra ganha
// L S - L P lagarto ganha
// S T - S P Spock ganha


// pedra, tesoura, papel, lagarto, spock 