using Enums_Collections___Task.Helpers;

namespace Enums_Collections___Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon myWeapon = new Weapon(BulletType.Regular, 10);

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Fill the weapon");
                Console.WriteLine("2. Fire the weapon");
                Console.WriteLine("3. Check the next bullet");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        myWeapon.Fill();
                        Console.WriteLine("Weapon filled.");
                        break;
                    case 2:
                        myWeapon.Fire();
                        break;
                    case 3:
                        myWeapon.PullTrigger();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select again.");
                        break;
                }
            }
        }
    }
}
