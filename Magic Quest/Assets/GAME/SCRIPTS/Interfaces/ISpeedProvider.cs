
// This interface defines a contract for speed-related properties in the game.
public interface ISpeedProvider 
{
    float CurrentSpeed { get; }
    float MaxSpeedPlayer     { get; }
    float AccelerationPlayer { get; }
}