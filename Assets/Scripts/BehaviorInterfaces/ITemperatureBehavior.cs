namespace BehaviorInterfaces {
    public interface ITemperatureBehavior {
        float Temperature { get; }
        void TemperatureChange(float change);
    }
}