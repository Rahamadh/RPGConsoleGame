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
        Personagem orc = new Orc();

        Combate combatente = new Combate();
        Item [] arma = { new Espada(),new Machado(),new MarteloGuerra() };
        heroi.nome = "Torvin, escudo de carvalho";
        heroi.definirRaca(new Anão());
        heroi.definirClasse(new Guerreiro());
        heroi.armaequipada = arma[0];

        
        Console.WriteLine($" Bem vindo{heroi.nome}, um terrivél {orc.nome} esbarra do seu caminho");
        

while(true)
{
          Console.WriteLine($"Nome: {heroi.nome}= Vida{heroi.vida} Mana {heroi.mana} || Inimigo {orc.nome} = {orc.vida}");

          combatente.defesaBase(heroi);
     
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
                        combatente.acaoDefensiva(heroi);
                        break;
                        case "S":
                        if( heroi.classe is Guerreiro guerreiro1)
                            {
                                guerreiro1.acaoEspecial(heroi,orc);
                            }
                        else if( heroi.classe is Mago mago1)
                            {
                                mago1.acaoEspecial(heroi,orc);
                            }
                        else if( heroi.classe is Ladino ladino1)
                            {
                                ladino1.acaoEspecial(heroi,orc);
                            }
                          
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
Console.WriteLine("Declare a ação Inimiga DEBUG");
entrada = Console.ReadLine();
 string acaoInimiga = entrada;

                        switch (acaoInimiga)
                    {
                        case "1":
                        combatente.acaoOfensiva(orc,heroi);
                        break;
                        case "2":
                        combatente.acaoDefensiva(orc);
                        break;
                        case "3":
                        if(orc is Orc orc1)
                            {
                                orc1.acaoMonstro(orc, heroi);
                            }
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

        public static void mostrarstatusEnemy (Personagem e)
        {
            Console.WriteLine($" vida Orc {e.vida}");
        }

            
    
}

}