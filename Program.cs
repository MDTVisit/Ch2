class Program
{
static void Main (string[] args)
{
       Stack<char> a = new Stack<char>();
       Stack2 <char> b = new Stack2<char>();
int i=0;
int j =0;

       
       while (true) {
       char c = char.Parse(Console.ReadLine());
 switch(c) {

 case '(':
        i++;
        break;

 case ')':
         j++;
        break;
        
default:
if (i == j)
Console.WriteLine("Valid");

else if (i != j)

Console.WriteLine("Invalid");
break;
}



}
}
}
