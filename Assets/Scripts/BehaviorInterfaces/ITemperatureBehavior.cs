namespace BehaviorInterfaces {
    public interface ITemperatureBehavior : IBehavior {
        float Temperature { get; }
        void TemperatureChange(float change);
    }
}