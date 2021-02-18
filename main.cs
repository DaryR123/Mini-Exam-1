using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Mini Exam 1");
  
  
for (int i = 0; i < 10; i++)
{
  Console.WriteLine("Enter name");
  string name = Console.ReadLine();

   Console.WriteLine("Enter your height in inches");
   double height = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Enter weight in pounds");
   double weight = Convert.ToDouble(Console.ReadLine());

double bmi = (703 * weight)/ (height * height);

Console.WriteLine("Your bmi is:" + bmi);

 if (bmi < 18.5)
 {
   Console.WriteLine("You are Underweight");
 }

else if (bmi >= 18.5 & bmi <= 24.9 )
 {
   Console.WriteLine("You are Normal");
 }

if (bmi >=25.0 & bmi <=29.9)
{
  Console.WriteLine("You are Overweight");
}

if (bmi > 30.0)
{
  Console.WriteLine("You are Obese");
}

}
  




  







  }
}