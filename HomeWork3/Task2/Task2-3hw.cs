// int ReadLine, double Distans_Between_Dots
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int c2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dot1 = (" + a1 +" "+ b1 +" "+ c1 + ")");
Console.WriteLine("Dot2 = (" + a2 +" "+ b2 +" "+ c2 + ")");


//d = Math.sqrt((x2-x1)^2+(y2-y1)^2+(z2-z1)^2)
Double Dist_Betw_Dots = Math.Sqrt((a2 - a1)*(a2 - a1) + (b2 - b1)*(b2 - b1) + (c2 - c1)*(c2 - c1));
Console.WriteLine(Dist_Betw_Dots);


