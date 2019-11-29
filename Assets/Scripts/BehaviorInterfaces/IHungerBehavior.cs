namespace BehaviorInterfaces
{
    public interface IHungerBehavior : IBehavior
    {
        float Hunger { get; }
        void HungerChange(float change);
    }
}