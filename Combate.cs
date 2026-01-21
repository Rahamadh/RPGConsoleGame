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
    public static int RolarDados (int quantidade, int faces)
    {
        int total = 0;


        for(int i = 0; i< quantidade; i++)
            {
                total += random.Next(1, faces +1);
            }
            return total;
        
    }
    


     


   

 public virtual void acaoOfensiva(Personagem atacante, Personagem alvo)
    {   int rolagemAtaque = 0;
        if( atacante.armaequipada.propiedades() == "Corpo-A-Corpo")
            {
                 rolagemAtaque = RolarDados(1,20) + atacante.corpoAcorpo;
            }
            else if (atacante.armaequipada.propiedades() == "À Distância")
            {
                 rolagemAtaque = RolarDados(1,20) + atacante.pontaria;
            }
            else if (atacante.armaequipada.propiedades() == "Magica")
            {
                 rolagemAtaque = RolarDados(1,20) + atacante.magia;
            }
            else
            {
                rolagemAtaque = RolarDados(1,20);
            }
        
        
        int danoBAse = (atacante.armaequipada != null)? atacante.armaequipada.rolarDano(): 1; 
        int rolagemDano = danoBAse;

        if(rolagemAtaque > alvo.defesa)
        {
            Console.WriteLine($"O {atacante.nome} acertou o atacaque com {atacante.armaequipada.nome} rolando {rolagemAtaque} pontos");

            Console.WriteLine($"O dano causado foi de {rolagemDano} de dano fisico");
            alvo.vida -= rolagemDano;
        }
        else
            {
                Console.WriteLine($"{atacante.nome} errou o ataque com {rolagemAtaque}");
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