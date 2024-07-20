using System;
class Demo12{
    public virtual void Taste(){
        Console.WriteLine("Kit Kat");
    }
}
class Demo13 : Demo12{
    public virtual void Taste(){
    
        Console.WriteLine("Dairy milk");
    }
}
class demo14:Demo13{
public override void Taste(){
    base.Taste();

    Console.WriteLine("Kinderjoy");
    }
       static void Main(string[] args){
          //  Demo13 d= new Demo13();
           // Demo12 d1= new Demo12();
            demo14 d2=new demo14();


            //d.Taste();
            //d1.Taste();
            d2.Taste();
        }

}
