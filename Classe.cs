using Character;

    public abstract class Classe
    {
        public string ClasseName = "";

        public Combate combate;
        public Personagem Personagem;

        public abstract void statusClasse (Personagem personagem);

     

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

    

}


