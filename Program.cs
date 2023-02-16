// See https://aka.ms/new-console-template for more information

int s1, s2, toplam, bolum_int;
float s3, s4, bolum_float;
double in_double, toplam_double, bolum_double;

s1 = 200;
s2 = 43;
s3 = 200;
s4 = 43;
toplam = s1 + s2;

bolum_int = s1/s2;
bolum_double = s1/s2;
bolum_float =s1/s2;
Console.WriteLine("*********** integer saayilar ***********");
Console.WriteLine("toplam: " + toplam);
Console.WriteLine("2 int sayinin bolumu - int: " + bolum_int);
Console.WriteLine("2 int sayinin bolumu - double: " + bolum_double);
Console.WriteLine("2 int sayinin bolumu - float: " + bolum_float);
Console.WriteLine("*********** float saayilar ***********");
bolum_double =s3/s4;
bolum_float =s3/s4;
Console.WriteLine("2 float sayinin bolumu - double: " + bolum_double);
Console.WriteLine("2 float sayinin bolumu - float: " + bolum_float);
Console.WriteLine("*********** type converter ***********");
in_double = Convert.ToDouble(Console.ReadLine());
toplam_double = in_double + bolum_double;
Console.WriteLine("double bolum ile double inputun toplamı: " + toplam_double);
