int  c = 0;

void tambah (int a,int b)
{
    c = a +b ;
    Console.WriteLine ($"{a}+{b}= {c}");
}
void kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a}-{b}= {c}");
}

void kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a}*{b}= {c}");
}

void bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a}/{b}= {c}");
}

tambah(34, 33);
kurang(50, 5);
kali(100, 50);
bagi(50, 5);
