class Program
{
static void Main (string[] args)
{
       Stack<char> a = new Stack<char>();
       Stack2 <char> b = new Stack2<char>();


       
       while (true) {
       char c = char.Parse(Console.ReadLine());
     if (c == '(') {a.Push('(');}
  
     if (c == ')') {b.Push(')');} 

    else if (c != ')' && c != '(');

 }
  if (a.GetLength == b.GetLength) {b.Push('A');}


  else
  {
      {a.Push('B');}

  }


}             
}


