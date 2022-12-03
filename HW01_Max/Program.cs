int a = 2;
int b = 3;
int c = 7;

int d = 44;
int e = 5;
int f = 78;

int g = 22;
int h = 3;
int i = 9;

int max1 = a;
int max2 = d;
int max3 = g;

if (a > max1) max1 = a;
if (b > max1) max1 = b;
if (c > max1) max1 = c;

if (d > max2) max2 = d;
if (e > max2) max2 = e;
if (f > max2) max2 = f;

if (g > max3) max3 = g;
if (h > max3) max3 = h;
if (i > max3) max3 = i;

Console.Write("max1 = ");
Console.WriteLine(max1);
Console.Write("max2 = ");
Console.WriteLine(max2);
Console.Write("max3 = ");
Console.WriteLine(max3);