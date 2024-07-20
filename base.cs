using System;
class a1{
    public string Nm{get;set;}
}
class a2:a1{
    public void add(){
        Console.WriteLine(base.Nm);

    }
    static void Main(string[] args){
        a2 n= new a2();
        n.Nm="Hello";
        n.add();
    }
}