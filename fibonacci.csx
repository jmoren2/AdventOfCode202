int fib = Int32.Parse(Args[0]);
Console.WriteLine("fibonacci of {0}", Args[0]);

int a,b =0;
int c = 1;

for(int i =0; i <= fib; ++i){
    a=b;
    b=c;

    c = a+ b;
    Console.WriteLine(a);
}