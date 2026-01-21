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
  
        
      
      // Jogador
        Personagem heroi = new Personagem();
        
        

        
       
        Race [] race = {new Anão(), new Elfo(), new Humano(), new Halfling()};
        Classe [] classe = {new Guerreiro(), new Mago(), new Ladino()};

        //Inimigo 
        Personagem[] enemy = {new Orc(), new Dragao()};
        
        int sortearInimigo = Combate.RolarDados(1,2);
        Personagem enemyAtual = enemy[sortearInimigo -1];
        

        //Armas & Itemns
         Arma [] arma = { new Espada(),new Machado(),new MarteloGuerra(), new Arco(), new Varinha() };

         //Combate
         Combate combatente = new Combate();

 
        
        //Inicio da construção de personagem
        Console.WriteLine("Vamos Iniciar sua aventura, Primeiro, diga o nome para seu heroi");
        heroi.nome = Console.ReadLine();
        
                     //ESCOLHA DA RACA
        Console.WriteLine("Agora, escolha sua Raça");
        for ( int i = 0;i< race.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {race[i].raceName}");
            }
        Race racaEscolhida = race[validarEscolha(race.Length)-1];
        heroi.definirRaca(racaEscolhida);


                  //ESCOLHA DA CLASSE
      for ( int i = 0;i< classe.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {classe[i].ClasseName}");
            }
    
        Classe classeEscolhida = classe[validarEscolha(classe.Length) -1];
        heroi.definirClasse(classeEscolhida);


                //Escolha Sua arma
        Console.WriteLine("Escolha sua Arma");

        for(int i = 0; i< arma.Length; i++)
            {
                Console.WriteLine($"{i+1} {arma[i].nome}");
            }
        
        
        Arma armaEscolhida = arma[validarEscolha(arma.Length) -1];
        heroi.armaequipada = armaEscolhida;

        mostrarStatus(heroi);

      

 
 Console.WriteLine($" Bem vindo {heroi.nome}");
 
 Thread.Sleep(1000);

 Console.WriteLine("Você esta caminhando pelas terras grandes planides de vendell...");
 Console.WriteLine($"Até quando um terrivel {enemyAtual.nome} suerge na sua frente");
 Console.WriteLine("Prepare-se para a luta");

 Thread.Sleep(1000);



// Combate por turno.
 
while(true)
{
          Console.WriteLine($"Nome: {heroi.nome} || Vida = {heroi.vida} Mana = {heroi.mana} || Inimigo {enemyAtual.nome} || Vida = {enemyAtual.vida} Mana = {enemyAtual.mana}");

          combatente.defesaBase(heroi);
     
MostrarMenuAcoes();
string entrada = Console.ReadLine();

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
                        case "1":
                        combatente.acaoOfensiva(heroi,enemyAtual);
                        break;
                        case "2":
                        combatente.acaoDefensiva(heroi);
                        break;
                        case "3":
                        if( heroi.classe is IacaoClasse heroi1)
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
Thread.Sleep(1500);
//_____________________________//____________________________________//
Console.WriteLine("Ação Inimiga: ");

int acaoInimiga = Combate.RolarDados(1,3);

                        switch (acaoInimiga)
                    {
                        case 1:
                        combatente.acaoOfensiva(enemyAtual,heroi);
                        break;
                        case 2:
                        combatente.acaoDefensiva(enemyAtual);
                        break;
                        case 3:
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
            Console.WriteLine($"Ataque {s.corpoAcorpo}");
            Console.WriteLine($"Defesa {s.defesa}");
            Console.WriteLine($"Pontaria{s.pontaria}");
            Console.WriteLine($"Magia {s.magia}");
            Console.WriteLine($"Arma{s.armaequipada.nome}");
        }

        public static void mostrarstatusEnemy (Personagem e)
        {
            Console.WriteLine($" vida Orc {e.vida}");
        }
private static int validarEscolha ( int max)
        { 
        int escolha;
        while (true) 
        
        { if (!int.TryParse(Console.ReadLine(), out escolha) || escolha <0 || escolha > max)  
          {
        Console.WriteLine("Escolha Invalida, tente novamente");
          }
          else
                {
                    return escolha;
                }    
        }
        }
       // public static int TestarDados () => Combate.RolarDados(10,10);

       //Menu de ações

       static void MostrarMenuAcoes()
{
    Console.Clear();
    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
    Console.WriteLine("┃          AÇÃO               ┃");
    Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
    Console.WriteLine("┃ 1. Atacar                   ┃");
    Console.WriteLine("┃ 2. Defender                 ┃");
    Console.WriteLine("┃ 3. Habilidade               ┃");
    Console.WriteLine("┃ 4. Fugir                    ┃");
    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    Console.Write("Escolha: ");
}



        
            
        
            
    
}

}