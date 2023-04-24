Console.WriteLine("Hello to Jeremy's Tip Calculator.");
Console.Write("How much is the total of the bill? ");
int totalBill = Convert.ToInt32(Console.ReadLine());    
Console.Write("How many people are paying the bill? ");
int peoplePaying = Convert.ToInt32(Console.ReadLine());
Console.Write("What percentage do you want to tip? ");
float tipPercentage = Convert.ToSingle(Console.ReadLine());
tipPercentage = Convert.ToSingle(tipPercentage * .01);
float tipAmount = (totalBill / peoplePaying) * tipPercentage; 

Console.WriteLine("The amount to tip for each person is " + tipAmount);
  