using System;
class Test8{
static void sm(int[] a1){
Console.WriteLine("printing array of elements");
for(int i =0;i<a1.length;i++)
{
Console.WriteLine(a1[i]);
}
}
static void Main(string [] args){
int[]  x={1,2,3,4,5,6};
int [] y={0,9,8,7,5};
sum(x);
sum(y);
}
}

