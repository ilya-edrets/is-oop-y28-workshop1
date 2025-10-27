namespace Workshop1.Entities.Damage
{
    public class Cannonball : IDamageSource
    {
        public int ImpactForce { get; }

        public float SplashDamage { get; set; }

        public void ApplyDamage(IDamagable damagable)
        {
            throw new NotImplementedException();
        }
    }
}
