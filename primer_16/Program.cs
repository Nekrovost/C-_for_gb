// int factorial(int n)
// {
//     if(n==1) return 1;
//     else  return n*factorial(n-1);
// }
// Console.WriteLine(factorial(5));

int fib(int n)
{
    if(n==1 || n==2) return 1;
    else return fib(n-1)+fib(n-2);
}
Console.WriteLine(fib(10));