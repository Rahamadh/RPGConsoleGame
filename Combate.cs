using System;
using RPG;
using Character;
using Monstro;
using System.Runtime.InteropServices.Marshalling;

namespace CalculoBatalha
{
public class  Combate
{ 
    


   public static Random random = new Random();
     public static int d20 () => random.Next(1,21);
     public static int d12 () => random.Next(1,13);
    
     public static int d10 () => random.Next(1,11);

     public static int d8 () =>  random.Next(1,9);
    
     public static int d6 () => random.Next(1,7);
    
     public static int d4 () => random.Next(1,5);


   

 public virtual void acaoOfensiva(Personagem atacante, Personagem alvo)
    {
        int rolagemAtaque = d20() + atacante.ataque;
        int danoBAse = (atacante.armaequipada != null)? atacante.armaequipada.rolarDano(): 1; 
        int rolagemDano = danoBAse;

        if(rolagemAtaque > alvo.defesa)
        {
            Console.WriteLine($"O ataque acertou com {rolagemAtaque} pontos");

            Console.WriteLine($"O dano causado foi de {rolagemDano} de dano fisico");
            alvo.vida -= rolagemDano;
        }
    

    }

    public virtual void acaoDefensiva(Personagem alvo)
    {
          
          if (!alvo.escudo)
        {  alvo.escudo = true;
           alvo.defesa += 5; 
           Console.WriteLine($"{alvo.nome} assumiu uma posição defensiva");
        }
          
          
          
    }
    public virtual void defesaBase (Personagem alvo)
    {
         
         if(alvo.escudo)
        {   alvo.escudo = false;
            alvo.defesa -= 5;
            Console.WriteLine($"{alvo.nome} baixou seu escudo");
        }
    }
    
      
    
}

}