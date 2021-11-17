namespace Attacker.Strategies
{
    internal class Plunger : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attacks with a plunger");
        }
    }
}
