namespace BehaviorInterfaces
{
    public interface IHungerBehaviour : IBehavior
    {
        float Hunger { get; }
        void HungerChange(float change);
    }
}