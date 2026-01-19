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
        personagem.ataque += 3 ;
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
        personagem.ataque += 2;
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
        personagem.vida += 5;
        personagem.mana += 5;
        personagem.ataque += 1;
        personagem.defesa += 1;
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
        personagem.vida -= 20 ;
        personagem.mana += 10 ;
        personagem.ataque += 5;
        personagem.defesa += 5 ;
    }
    
}
