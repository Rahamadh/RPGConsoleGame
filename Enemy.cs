using Character;
namespace vilao
{
    public class Orc : Personagem
    {
        public Orc()
    {
     nome = "orc";
     vida += 20;
     mana -=20;
     ataque += 5;
        
     this.armaequipada = new Machado();   
    }
      
        
           
        
       public virtual void acaoMonstro (Personagem atacante, Personagem alvo)
        {
            int investidaBrutal = Combate.d4();
            int danoBrutal = Combate.d10() *2; 

            if (atacante.mana >= 0)
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
    }
  
}