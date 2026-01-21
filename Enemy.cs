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
            
            int investidaBrutal = Combate.RolarDados(1,4);
            int danoBrutal = Combate.RolarDados(2,10); 

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
     corpoAcorpo += 5;
        
     this.armaequipada = new Machado();   
    }
      
    }


    //DRAGAO
   public class Dragao : Personagem, IacaoMonstro
    {   
        public void acaoMonstro (Personagem atacante, Personagem alvo)
        {
            int soproFogo = Combate.RolarDados(1,6);
            int danoFogo = Combate.RolarDados(10,6) ;

            if (atacante.mana <= 0)
            {
                Console.WriteLine($"{atacante.nome} Não tem energia para seu Sopro");
            }
            else
            {
                if(soproFogo >= 4)
                {
                    Console.WriteLine($"{atacante.nome} exele uma rajada flamejante causado {danoFogo} de dano de fogo");
                    alvo.vida -= danoFogo;
                }
            }
        }

        public Dragao()
    {
     nome = "Smaug, O Dourado";
     vida += 50;
     mana +=40;
     corpoAcorpo += 10;
     defesa += 5;
        
     this.armaequipada = new ArmaNatural();
     
        
    }
       
           
        
       
    }
  
}