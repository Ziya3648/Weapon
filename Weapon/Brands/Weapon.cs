namespace WeaponProject.Brands;

public class Weapon
{
    public string BrandName;

    public Weapon(string brandname)
    {
        BrandName = brandname;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Silahın növü: {BrandName}" );    
    }
}


