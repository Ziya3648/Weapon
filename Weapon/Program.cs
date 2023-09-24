using System.Reflection.PortableExecutable;
using WeaponProject.Brands;

char options;


Console.WriteLine("Zehmet olmasa silahin novunu secin:"+
    $"\n A. Avtomat;" +
    $"\n B. Tapanca.");


var optionsAsChar = Console.ReadLine();
optionsAsChar = optionsAsChar.ToUpper();

bool parseSuccess = char.TryParse(optionsAsChar, out options);

if (parseSuccess && options == 'A')
    {
        AssaultRifle rifle = new AssaultRifle("Avtomat", "AK-74", 540, 24, 100, 40);
        rifle.ShowInfo();
        Console.WriteLine(" Zehmet millisaniyeni daxil edin:");
        var milliseconds = Convert.ToInt32(Console.ReadLine());
        rifle.CalcFireCount(milliseconds);
    }
if (parseSuccess && options == 'B')
{
    Pistol pistol = new Pistol("Tapanca", "Makarov  IJ70-18A", 8, 6, 30);
    pistol.ShowInfo();
    Console.WriteLine(" Zehmet millisaniyeni daxil edin:");
    var milliseconds = Convert.ToInt32(Console.ReadLine());
    pistol.CalcFireCount(milliseconds);
}
else
    {
    Console.WriteLine("Duzgun opsiyani secmediniz (A,a,B,b daxil edin)!");
    }



