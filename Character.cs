
using System.Reflection.PortableExecutable;
using vilao;

namespace Character

{
    public class Personagem 
    {
      public  string nome = "";
       public int vida = 100;
       public int mana = 50;
       public int ataque = 5;
       public int defesa = 10;

       public bool escudo = false;


       public Race race;
       public Classe classe;

       public Item armaequipada;

       public void definirRaca (Race race)
        {
            
            race.StatusRaciais(this);
            this.race = race;
            
                 
        }
        public void definirClasse (Classe classe)
        {
            classe.statusClasse(this);
            this.classe = classe;
            
        }
      
    
    }
}