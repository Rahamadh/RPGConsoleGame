using Character;
using RPG;
using CalculoBatalha;


namespace Monstro

{
     public interface IacaoMonstro 
    { 
        void acaoMonstro(Personagem atacante, Personagem Alvo);
    }
 
    
    public class Orc : Personagem, IacaoMonstro

    {
       public void acaoMonstro (Personagem atacante, Personagem alvo)
        {
            
            int investidaBrutal = Combate.d4();
            int danoBrutal = Combate.d10() *2; 

            if (atacante.mana >= 10)
            {
                atacante.mana -= 10;

                if (investidaBrutal >=3)
                {
                    Console.WriteLine($"O Orc ataca {alvo.nome} brutalmente");
                    Console.WriteLine($"O alvo sofre {danoBrutal} de dano Fisico");
                    alvo.vida -= danoBrutal;

                }
                else
                {
                    Console.WriteLine($"{atacante.nome} Errou o ataque");
                }
            }
            else
            {
                Console.WriteLine("Mana Insuficiente");
            }
        }
        public Orc()
    {
     nome = "orc";
     vida += 20;
     mana -=20;
     ataque += 5;
        
     this.armaequipada = new Machado();   
    }
      
    }


    //DRAGAO
   public class Dragao : Personagem, IacaoMonstro
    {   
        public void acaoMonstro (Personagem atacante, Personagem alvo)
        {
            int sofroFogo = Combate.d6();
            int danoFogo = Combate.d6() *10;

            if (atacante.mana <= 0)
            {
                Console.WriteLine($"{atacante.nome} Não tem energia para seu Sopro");
            }
            else
            {
                if(sofroFogo >= 4)
                {
                    Console.WriteLine($"{atacante.nome} exele uma rajada flamejante causado {danoFogo} de dano de fogo");
                    alvo.vida -= danoFogo;
                }
            }
        }

        public Dragao()
    {
     nome = "Smaug O Dourado";
     vida += 50;
<<<<<<< HEAD
     mana -=40;
=======
     mana +=40;
>>>>>>> 04d6705 (randomizaçao das açoes do inimigo)
     ataque += 10;
     defesa += 5;
        
     this.armaequipada = new ArmaNatural();
     
        
    }
       
           
        
       
    }
  
}