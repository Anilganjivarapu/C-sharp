using System;
class Test41{
int marks;
int a=50;
public Test41(){
marks=98;
a=90;
}
//void add(){
//marks=68;
//Console.WriteLine(marks);
//}

static void Main(string[] args)
{
Test41 t1=new Test41();
Console.WriteLine(t1.marks);
Console.WriteLine(t1.a);


}
}