using System;
using System.Security.Cryptography.X509Certificates;

namespace WeaponProject.Brands
{
    public class AssaultRifle : Weapon
    {
        public string Model;
        public int BulletCapacity;
        public int CurrentBulletCount;
        public int RateOfFireAuto;
        public int RateOfFireManual;
        public AssaultRifle(string brandname, 
            string model, 
            int bulletCapacity, 
            int currentBulletCount, 
            int rateOfFireAuto,
            int rateOfFireManual) : base(brandname)
        {
            Model = model;
            BulletCapacity = bulletCapacity;
            CurrentBulletCount = currentBulletCount;
            RateOfFireAuto = rateOfFireAuto;
            RateOfFireManual = rateOfFireManual;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Silahın növü: {BrandName};" +
                $"\n Silahın modeli: {Model};" +
                $"\n Silahın patron tutumu (18 dolu maqazinle): {BulletCapacity} patron;" +
                $"\n Maqazinde cari patron sayi: {CurrentBulletCount};" +
                $"\n Avtomatik rejimde atis sayi: {RateOfFireAuto} atış/deq (60000 millisaniye);" +
                $"\n Manual rejimde atis sayi: {RateOfFireManual} atış/deq (60000 millisaniye);");
        }

        public void CalcFireCount(int milliseconds)
        {

            int fireCountAuto   = (milliseconds * RateOfFireAuto) / 60000;
            int fireCountManual = (milliseconds * RateOfFireManual) / 60000;

            bool canFireAuto = (fireCountAuto <= CurrentBulletCount);
            bool canFireManual = (fireCountManual <= CurrentBulletCount);

            Console.WriteLine($"Daxil etdiyiniz millisaniye uzre avtomatik rejimde atis sayi: {fireCountAuto}");
            Console.WriteLine($"Daxil etdiyiniz millisaniye uzre tek-tek rejimde atis sayi: {fireCountManual}");

            if (canFireAuto)
            {
                Console.WriteLine("Avtomatik rejimde atisi heyata kecirmek mumkundur");
            }
        else 
            {
                Console.WriteLine($"Avtomatik rejimde atis mumkun deyil (patron sayi: {CurrentBulletCount})");
                int reqBullet = (fireCountAuto - CurrentBulletCount);
                Console.WriteLine($"Avtomatik rejimde atis ucun teleb olunan patron sayi: {reqBullet})");
            }
            if (canFireManual)
            {
                Console.WriteLine("Tek-tek rejimde atisi heyata kecirmek mumkundur");
            }
            else
            {
                Console.WriteLine($"Tek-tek rejimde atis mumkun deyil (patron sayi: {CurrentBulletCount})");
                int reqBullet = (fireCountManual - CurrentBulletCount);
                Console.WriteLine($"Tek-tek rejimde atis ucun teleb olunan patron sayi: {reqBullet})");
            }
        }
    

    }
}
