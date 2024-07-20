using System;
class C2{
    public delegate void rect(double height, double width);
    public void area(double height, double width){
        Console.WriteLine("Area of rectangle is: "+(height*width));
    }
    public void perimeter(double height, double width){
        Console.WriteLine("Perimeter of rectangle is: "+(2*(height+width)));
    }
    static void Main(string[] args){
        C2 c = new C2();
        rect r = new rect(c.area);
        r+=c.perimeter;
        r.Invoke(4,5.4);
        Console.WriteLine();
        r.Invoke(6,7.8);
    }
}