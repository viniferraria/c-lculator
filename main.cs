using System;

class MainClass{
  public static void Main (string[] args){
   Console.WriteLine("hello");
   do{
   Console.Write("1:+\n2:-\n3:%\n4:*\n5:division\n6:x^2\nInput:");
   string x = Console.ReadLine();
   if (x=="1"){
      Console.Write("A =");
      double a = Convert.ToDouble(Console.ReadLine());
      Console.Write("B =");
      double b = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("\nSum:"+(a+b)+"\n");
   }
   else if (x=="2"){
     Console.Write("A =");
     double a = Convert.ToDouble(Console.ReadLine());
     Console.Write("B =");
     double b = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("\nMinus:"+(a-b)+"\n");
   }
   else if (x=="3"){
     Console.Write("A =");
     double a = Convert.ToDouble(Console.ReadLine());
     Console.Write("B =");
     double b = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("\nResto:"+(a%b)+"\n");
   }
   else if ( x=="4"){
     Console.Write("A =");
     double a = Convert.ToDouble(Console.ReadLine());
     Console.Write("B =");
     double b = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("\nResto:"+(a*b)+"\n");
   }
   else if (x=="5"){
     Console.Write("A =");
     double a = Convert.ToDouble(Console.ReadLine());
     Console.Write("B =");
     double b = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("\nDivision:"+(a/b)+"\n");
   }
   else if (x=="6"){
     Console.Write("A =");
     double a = Convert.ToDouble(Console.ReadLine());
     Console.Write("B =");
     double b = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine("\n**2:"+(a*a)+"\n"+(b*b)+"\n");
   }
   }
   while(true);
}
}