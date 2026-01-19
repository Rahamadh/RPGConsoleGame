using System;
using System.Collections.Generic;
using Character;
using vilao;

namespace RPG
{
    
public class Program
{
    static void Main (string []args)
    {
        Personagem heroi = new Personagem();
        Orc orc = new Orc();
        Combate combatente = new Combate();
        Item [] arma = { new Espada(),new Machado(),new MarteloGuerra() };
        heroi.nome = "Torvin, escudo de carvalho";
        heroi.definirRaca(new Anão());
        heroi.definirClasse(new Guerreiro());
        heroi.armaequipada = arma[0];
        orc.armaequipada = arma[1];
        
        Console.WriteLine($"{heroi.classe.ClasseName}, {heroi.race.raceName} {heroi.race.habilidade} {heroi.armaequipada.nome} ");
        mostrarStatus(heroi);

while(true)
{
          Console.WriteLine($"{heroi.vida}, {orc.vida}");
     
        Console.WriteLine("Escolha sua ação A - atacar, D defender - S habilidade especial");

        string entrada = Console.ReadLine().ToUpper();

        string acao = entrada;

        if(string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Erro violento, programa encerrado");
                continue;
            }
            else
                {
                    switch (acao)
                    {
                        case "A":
                        combatente.acaoOfensiva(heroi,orc);
                        break;
                        case "D":
                        combatente.acaoOfensiva(heroi,orc);
                        break;
                        case "S":
                        combatente.acaoOfensiva(heroi,orc);
                        break;
                        default:
                        Console.WriteLine("Comando invalido");
                        break;
                    }
                   
                   
                    if (orc.vida <= 0)
                    {
                        Console.WriteLine("Voce venceu o combate");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O inimigo ainda luta");
                    }

//_____________________________//____________________________________//
int acaoInimiga = 1;

                        switch (acaoInimiga)
                    {
                        case 1:
                        combatente.acaoOfensiva(orc,heroi);
                        break;
                        default:
                        Console.WriteLine("Comando invalido");
                        break;
                    }
                 if (heroi.vida <= 0)
                    {
                        Console.WriteLine("O heroi caiu");
                        break;

                    } 
                    else
                    {
                        Console.WriteLine("A luta continua");
                    }  
            


  }


     
        
}

    }
    public static void mostrarStatus(Personagem s) //função auxiliar, apenas para exibir dados
        {   
            Console.WriteLine($"Vida {s.vida}");
            Console.WriteLine($"Mana {s.mana}");
            Console.WriteLine($"Ataque {s.ataque}");
            Console.WriteLine($"Defesa {s.defesa}");
        }

            
    
}

}