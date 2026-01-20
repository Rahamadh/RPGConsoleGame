using System.Xml;
using Character;
using CalculoBatalha;

public abstract class Item
{   
    public string nome = "";
     public abstract int rolarDano ();
}

public class ArmaNatural : Item
{
    public ArmaNatural()
    {
        nome = "Garras";
    }
    public override int rolarDano() => Combate.d12();
}

public class Espada : Item
{
     public Espada()
    {
        nome = "Espada Longa";
    }
    
    public override int rolarDano () => Combate.d8();
    

}
public class MarteloGuerra : Item
{
     public MarteloGuerra()
    {
        nome = "Martelo De Guerra";
    }
    
    public override int rolarDano () => Combate.d8();
    

}
public class Machado : Item
{
     public Machado()
    {
        nome = "Machado Grande";
    }
    
    public override int rolarDano () => Combate.d12();
    

}
