using Enums_Collections___Task.Helpers;

namespace Enums_Collections___Task;

public class Weapon
{
    private static int _id;
    public int Id { get; }
    public BulletType Type { get; }
    public int Capacity { get; }
    private List<Bullet> _magazine;

    public Weapon(BulletType type, int capacity)
    {
        Id = ++_id;
        Type = type;
        Capacity = capacity;
        _magazine = new List<Bullet>();
    }

    public void Fill()
    {
        _magazine.Clear();
        for (int i = 0; i < Capacity; i++)
        {
            _magazine.Add(new Bullet(Type));
        }
    }

    public void Fire()
    {
        if (_magazine.Count > 0)
        {
            Bullet firedBullet = _magazine[0];
            _magazine.RemoveAt(0);
            Console.WriteLine($"Fired {firedBullet}. Bullets left: {_magazine.Count}");
        }
        else
        {
            Console.WriteLine("No bullets left to fire.");
        }
    }

    public void PullTrigger()
    {
        if (_magazine.Count > 0)
        {
            Bullet nextBullet = _magazine[0];
            Console.WriteLine($"Next bullet to fire: {nextBullet}");
        }
        else
        {
            Console.WriteLine("No bullets left in the magazine.");
        }
    }
}
