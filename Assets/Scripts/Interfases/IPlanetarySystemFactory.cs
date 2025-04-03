namespace Interfases
{
    public interface IPlanetarySystemFactory
    {
        public abstract IPlanetarySystem Create(double mass);
    }
}
