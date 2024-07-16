using Enums_Collections___Task.Helpers;

namespace Enums_Collections___Task
{
    public class Bullet
    {
        private static int _id;
        public int Id { get; }
        public BulletType Type { get; }

        public Bullet(BulletType type)
        {
            Id = ++_id;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type} Bullet (ID: {Id})";
        }
    }

}
