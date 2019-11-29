namespace BehaviorInterfaces {
    public interface IDurabilityBehavior: IBehavior{
        float Durability { get; }    
        void DurabilityChange(float change);
    }
}