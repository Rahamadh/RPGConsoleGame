using System.Xml;
using Character;
using CalculoBatalha;

public abstract class Arma
{   
    public string nome = "";
     public abstract int rolarDano ();
     public abstract string propiedades ();
}

public class ArmaNatural : Arma
{
    public ArmaNatural()
    {
        nome = "Garras";
    }
    public override string propiedades()  {string tipo = "Corpo-A-Corpo"; return tipo;}
    public override int rolarDano() => Combate.RolarDados(2,10);
}

public class Espada : Arma
{
     public Espada()
    {
        nome = "Espada Longa";
    }
    public override string propiedades()  {string tipo = "Corpo-A-Corpo"; return tipo;}
    public override int rolarDano () => Combate.RolarDados(1,8);
    

}
public class MarteloGuerra : Arma
{
     public MarteloGuerra()
    {
        nome = "Martelo De Guerra";
    }
    public override string propiedades()  {string tipo = "Corpo-A-Corpo"; return tipo;}
    public override int rolarDano () => Combate.RolarDados(1,10);
    

}
public class Machado : Arma
{
     public Machado()
    {
        nome = "Machado Grande";
    }
    public override string propiedades()  {string tipo = "Corpo-A-Corpo"; return tipo;}
    public override int rolarDano () => Combate.RolarDados(1,12);
    

}
public class Arco : Arma
{
     public Arco()
    {
        nome = "Arco Longo";
        
    }
    public override string propiedades()  {string tipo = "À Distância"; return tipo;}
   
    public override int rolarDano () => Combate.RolarDados(1,12);
    

}
public class Varinha : Arma
{
     public Varinha()
    {
        nome = "Varinha";
        
    }
    public override string propiedades()  {string tipo = "Magica"; return tipo;}
   
    public override int rolarDano () => Combate.RolarDados(2,12);
    

}


