
using System.Reflection.PortableExecutable;
using Monstro;

namespace Character

{
    public class Personagem 
    {
      public  string nome = "";
       public int vida = 50;
       public int mana = 50;
       public int corpoAcorpo = 1;
       public int pontaria = 1;
       public int magia = 0;
       public int defesa = 10;

       public bool escudo = false;

       public Race race;
       public Classe classe;
       public Arma armaequipada;

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