namespace Workshop1.Entities.Damage
{
    public class Missile : IDamageSource
    {
        public int Payload { get; set; }

        public int ExplosionRadius { get; set; }

        public DamageType DamageType { get; set; }

        public void ApplyDamage(IDamagable damagable)
        {
            throw new NotImplementedException();
        }
    }

    public enum DamageType
    {
        Explosive,
        Incendiary,
        EMP
    }
}
