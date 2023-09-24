using System;
using System.Security.Cryptography.X509Certificates;

namespace WeaponProject.Brands
{
    public class Pistol : Weapon
    {
        public string Model;
        public int BulletCapacity;
        public int CurrentBulletCount;
        public int RateOfFireManual;
        public Pistol(string brandname,
            string model,
            int bulletCapacity,
            int currentBulletCount,
            int rateOfFireManual) : base(brandname)
        {
            Model = model;
            BulletCapacity = bulletCapacity;
            CurrentBulletCount = currentBulletCount;
            RateOfFireManual = rateOfFireManual;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($" Silahın növü: {BrandName};" +
                $"\n Silahın modeli: {Model};" +
                $"\n Silahın patron tutumu (18 dolu maqazinle): {BulletCapacity} patron;" +
                $"\n Maqazinde cari patron sayi: {CurrentBulletCount};" +
                $"\n Avtomatik rejimde atis sayi: Bu rejim tapancada movcud deyil;" +
                $"\n Manual rejimde atis sayi: {RateOfFireManual} atış/deq (60000 millisaniye);");
        }

        public void CalcFireCount(int milliseconds)
        {

            int fireCountManual = (milliseconds * RateOfFireManual) / 60000;
            bool canFireManual = (fireCountManual <= CurrentBulletCount);
            Console.WriteLine($"Daxil etdiyiniz millisaniye uzre tek-tek rejimde atis sayi: {fireCountManual}");

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
