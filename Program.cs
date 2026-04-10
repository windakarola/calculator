// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 16;

static int Penjumlahan(int var1, int var2)
{
    return var1 + var2;
}

static int Pengurangan(int var1, int var2)
{
    return var1 - var2;
}

static int Perkalian(int var1, int var2)
{
    return var1 * var2;
}

static int Pembagian(int var1, int var2)
{
    return var1 / var2;
}

Console.WriteLine(a + "+" + b + "=" + Penjumlahan(a, b));
Console.WriteLine(a + "-" + b + "=" + Pengurangan(a, b));
Console.WriteLine(a + "*" + b + "=" + Perkalian(a, b));
Console.WriteLine(a + "/" + b + "=" + Pembagian(a, b));
