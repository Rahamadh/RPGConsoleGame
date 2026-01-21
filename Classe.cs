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
        personagem.corpoAcorpo +=1;
        personagem.defesa +=1;

    }
        public Guerreiro()   //contrutor
       {
        ClasseName = "Guerreiro";
       }
       public void acaoClasse (Personagem atacante, Personagem alvo)
    {
        int dadoVida = Combate.RolarDados(2,10);

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
public class Mago : Classe, IacaoClasse
{
     public Mago()
    {
        ClasseName = "Mago";
    }
    public override void statusClasse (Personagem personagem)
    {
        personagem.vida += 0;
        personagem.mana += 20;
        personagem.corpoAcorpo -=2;
        personagem.defesa +=1;
        personagem.magia += 10;

    }
     public void acaoClasse (Personagem atacante, Personagem alvo)
    {

        int conjuracao = Combate.RolarDados(1,20) + atacante.magia;
        int danoMagico = Combate.RolarDados(6,6);
        
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
public class Ladino : Classe, IacaoClasse
{
     public Ladino()
    {
        ClasseName = "Ladino";
    }
    public override void statusClasse (Personagem personagem)
    {
        personagem.vida += 0 ;
        personagem.mana -= 0;
        personagem.corpoAcorpo +=7;
        personagem.defesa +=5;

    }
        public void acaoClasse (Personagem atacante, Personagem alvo)
        {
            int ataqueArdiloso = Combate.RolarDados(1,6);
            int danoBase = (atacante.armaequipada != null) ? atacante.armaequipada.rolarDano() :1; 
            int danoArdiloso =  danoBase + Combate.RolarDados(2,6);

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


