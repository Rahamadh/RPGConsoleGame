using System;
using RPG;
using Character;
using vilao;

public class  Combate
{ 
    public Personagem personagem;

    public Classe classe;

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
        int rolagemDano = atacante.ataque + atacante.armaequipada.rolarDano();

        if(rolagemAtaque > alvo.defesa)
        {
            Console.WriteLine($"O ataque acertou com {rolagemAtaque} pontos");

            Console.WriteLine($"O dano causado foi de {rolagemDano}");
            alvo.vida -= rolagemDano;
        }
    

    }
}