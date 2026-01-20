using System;
using System.Collections.Generic;
using Character;
using Monstro;
using CalculoBatalha;
using System.Threading.Tasks.Dataflow;

namespace RPG
{
    
public class Program
{
    static void Main (string []args)
    {
        Personagem heroi = new Personagem();
        Personagem[] enemy = {new Orc(), new Dragao()};
        Personagem enemyAtual = enemy[0];

        Console.WriteLine(enemyAtual);

        Combate combatente = new Combate();
        Item [] arma = { new Espada(),new Machado(),new MarteloGuerra() };
        Race [] race = {new Anão(), new Elfo(), new Humano(), new Halfling()};
        Classe [] classe = {new Guerreiro(), new Mago(), new Ladino()};

        Console.WriteLine("Vamos Montar seu heroi...primeiro, esoclha sua Raça");


                     //ESCOLHA DA RACA

        for ( int i = 0;i< race.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {race[i].raceName}");
            }
        int Escolha;
        while (true) 
        
        { if (!int.TryParse(Console.ReadLine(), out Escolha) || Escolha <0 || Escolha > 4)  
          {
        Console.WriteLine("Escolha Invalida, tente novamente");
          }
          else
                {
                    break;
                }    
        }
        Race racaEscolhida = race[Escolha-1];
        heroi.definirRaca(racaEscolhida);

        Escolha = 0;
                  //ESCOLHA DA CLASSE
      for ( int i = 0;i< classe.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {classe[i].ClasseName}");
            }
  while (true) 
        
        { if (!int.TryParse(Console.ReadLine(), out Escolha) || Escolha <0 || Escolha > 4)  
          {
        Console.WriteLine("Escolha Invalida, tente novamente");
          }
          else
                {
                    break;
                }    
        }
        Classe classeEscolhida = classe[Escolha-1];
        heroi.definirClasse(classeEscolhida);


                //Escolha Sua arma
        Console.WriteLine("Escolha sua Arma");

        for(int i = 0; i< arma.Length; i++)
            {
                Console.WriteLine($"{i+1} {arma[i].nome}");
            }
            Escolha = 0;
         while (true) 
        
        { if (!int.TryParse(Console.ReadLine(), out Escolha) || Escolha <0 || Escolha > 4)  
          {
        Console.WriteLine("Escolha Invalida, tente novamente");
          }
          else
                {
                    break;
                }    
        }
        
        Item armaEscolhida = arma[Escolha -1];
        heroi.armaequipada = armaEscolhida;

        mostrarStatus(heroi);
 
        Console.WriteLine($" Bem vindo{heroi.nome}, um terrivél {enemyAtual.nome} esbarra do seu caminho");



// Combate por turno.

while(true)
{
          Console.WriteLine($"Nome: {heroi.nome}= Vida{heroi.vida} Mana {heroi.mana} || Inimigo {enemyAtual.nome} = {enemyAtual.vida}");

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
                        combatente.acaoOfensiva(heroi,enemyAtual);
                        break;
                        case "D":
                        combatente.acaoDefensiva(heroi);
                        break;
                        case "S":
                        if( heroi is IacaoClasse heroi1)
                            {
                                heroi1.acaoClasse(heroi,enemyAtual);
                            }  
                        break;
                        default:
                        Console.WriteLine("Comando invalido");
                        break;
                    }
                   
                   
                    if (enemyAtual.vida <= 0)
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
                        combatente.acaoOfensiva(enemyAtual,heroi);
                        break;
                        case "2":
                        combatente.acaoDefensiva(enemyAtual);
                        break;
                        case "3":
                        if(enemyAtual is IacaoMonstro monstro)
                            {
                            monstro.acaoMonstro(enemyAtual, heroi);
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
            Console.WriteLine($"{s.armaequipada.nome}");
        }

        public static void mostrarstatusEnemy (Personagem e)
        {
            Console.WriteLine($" vida Orc {e.vida}");
        }

            
    
}

}