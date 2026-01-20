using System.Data;
using Character;
using CalculoBatalha;


 public interface IacaoClasse 
   { 
    void acaoClasse (Personagem atacante,Personagem alvo);
    }
   
   
    public abstract class Classe
    {
        public string ClasseName = "";

        public abstract void statusClasse (Personagem personagem);
       
       
    }

    //_______________________GUERREIRO________________________
    public class Guerreiro : Classe, IacaoClasse
{   public override void statusClasse (Personagem personagem)
    {
        personagem.vida += 20;
        personagem.mana -= 20;
        personagem.ataque +=1;
        personagem.defesa +=1;

    }
        public Guerreiro()   //contrutor
       {
        ClasseName = "Guerreiro";
       }
       public void acaoClasse (Personagem atacante, Personagem alvo)
    {
        int dadoVida = Combate.d10();

        if(alvo.mana >= 10)
        {
            alvo.vida += dadoVida;
        }
        else
        {
            Console.WriteLine("Mana insuficiente");
        }
    }
}


//___________MAGO_______________
public class Mago : Classe
{
     public Mago()
    {
        ClasseName = "Mago";
    }
    public override void statusClasse (Personagem personagem)
    {
        personagem.vida += 0;
        personagem.mana += 20;
        personagem.ataque +=2;
        personagem.defesa +=2;
        personagem.ataqueMagico += 10;

    }
     public void acaoClasse (Personagem atacante, Personagem alvo)
    {

        int conjuracao = Combate.d20() + atacante.ataqueMagico;
        int danoMagico = Combate.d6() *4;
        
      if(atacante.mana <= 0)
        {
            Console.WriteLine("Mana insuficiente");
        }
        else
        {
             if(conjuracao > alvo.defesa)
            {
                atacante.mana -=10;
                
              alvo.vida -= danoMagico;
              Console.WriteLine($"{atacante.nome} Conjura uma Bola De Fogo!!! e causa {danoMagico} de dano de fogo");
            }
              else
            {
                Console.WriteLine("Voce errou a magia");
            }   
        }
            
    }
}

//________________________LADINO_____________________________________
public class Ladino : Classe
{
     public Ladino()
    {
        ClasseName = "Ladino";
    }
    public override void statusClasse (Personagem personagem)
    {
        personagem.vida += 0 ;
        personagem.mana -= 0;
        personagem.ataque +=7;
        personagem.defesa +=5;

    }
        public void acaoClasse (Personagem atacante, Personagem alvo)
        {
            int ataqueArdiloso = Combate.d6();
            int danoBase = (atacante.armaequipada != null) ? atacante.armaequipada.rolarDano() :1; 
            int danoArdiloso =  danoBase*2;

            if ( ataqueArdiloso >= 5)
        {
            Console.WriteLine($"{atacante.nome} ataca o {alvo.nome} desprevenido");
            alvo.vida -= danoArdiloso;
            Console.WriteLine($"O {alvo.nome} sofre {danoArdiloso} de dano fisico");
        }
        else
        {
            Console.WriteLine("Voce falhou e sofreu dano");

            atacante.vida -= 10;
        }
        }

    

}


