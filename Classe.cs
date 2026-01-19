using System.Data;
using Character;

    public abstract class Classe
    {
        public string ClasseName = "";

        public Combate combate;
        public Personagem Personagem;
    

        public abstract void statusClasse (Personagem personagem);
        public abstract void acaoEspecial (Personagem atacante,Personagem alvo);
       

     

    }

    //_______________________GUERREIRO________________________
    public class Guerreiro : Classe
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
    public override void acaoEspecial(Personagem atacante, Personagem alvo)
    {
        if(atacante.mana <= 0)
        {
            Console.WriteLine("Mana insuficiente");
        }
        else
        {   atacante.vida += 20;
            Console.WriteLine("O guerreiro recupera o folego restaurando vida");
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

    }
     public override void acaoEspecial(Personagem atacante, Personagem alvo)
    {

        int conjuracao = Combate.d20() + atacante.ataque;
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
                Console.WriteLine("Bola De Fogo!!!!");
              alvo.vida -= danoMagico;
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
        public override void acaoEspecial(Personagem atacante, Personagem alvo)
        {
            int ataqueArdiloso = Combate.d6();
            int danoArdiloso = atacante.armaequipada.rolarDano() *2;

            if ( ataqueArdiloso >= 5)
        {
            Console.WriteLine("Ataque fatal");
            alvo.vida -= danoArdiloso;
        }
        else
        {
            Console.WriteLine("Voce falhou e sofreu dano");

            atacante.vida -= 10;
        }
        }

    

}


