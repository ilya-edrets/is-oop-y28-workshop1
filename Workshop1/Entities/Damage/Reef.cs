namespace Workshop1.Entities.Damage
{
    public class Reef : IDamageSource
    {
        public float Visibility { get; }

        public int Hardness { get; }

        public int Size { get; set; }

        public void ApplyDamage(IDamagable damagable)
        {
            throw new NotImplementedException();
        }
    }
}
