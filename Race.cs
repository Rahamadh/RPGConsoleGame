using System;
using Character;
public abstract class Race
    {
  public abstract void StatusRaciais(Personagem personagem);
       public string habilidade = "";
       public string raceName = "";
    }
    public class Elfo : Race   
{   public Elfo()
    {
        habilidade = "Pontaria Precisa";
        raceName = "Elfo";    
    }
    public override void StatusRaciais (Personagem personagem)
   
    {
        personagem.vida -= 10 ;
        personagem.mana += 10;
        personagem.corpoAcorpo += 1 ;
        personagem.pontaria += 3;
        personagem.magia += 2;
        personagem.defesa += 2;
    }
        
   
}
public class Anão : Race
{   public Anão ()
    {   
         
        habilidade = "Resiliente";
        raceName = "Anão";
    }
     public override void StatusRaciais (Personagem personagem)
    {
        personagem.vida += 10;
        personagem.mana -= 10;
        personagem.corpoAcorpo += 2 ;
        personagem.pontaria -= 2;
        personagem.magia += 0;
        personagem.defesa += 5;
    }
    
}
public class Humano : Race
{    public Humano()
    {
        habilidade ="Adaptativo";
        raceName = "Humano";
    }
    
    public override void StatusRaciais (Personagem personagem)
    {
        personagem.vida += 2;
        personagem.mana += 2;
        personagem.corpoAcorpo += 2;
        personagem.pontaria +=2;
        personagem.defesa += 2;
        personagem.magia =+2;
    }
   
}
public class Halfling : Race
{   public Halfling()
    {
        habilidade = "agil";
        raceName = "halfling";
    } 
    
    public override void StatusRaciais (Personagem personagem)
    {
        personagem.vida -= 20;
        personagem.mana += 20;
        personagem.corpoAcorpo += 5;
        personagem.pontaria +=5;
        personagem.defesa += 5;
        personagem.magia =+5;
    }
    
}
