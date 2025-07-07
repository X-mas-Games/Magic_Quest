
using UnityEngine;
using UnityEngine.Serialization;


 [CreateAssetMenu(menuName = "Configs/SpeedConfig", fileName = "SpeedConfig")]
 public partial class SpeedConfig : ScriptableObject, ISpeedProvider // Assuming ISpeedProvider is defined elsewhere
{
    
    [SerializeField] private float maxSpeedPlayer ; 
    [SerializeField] private float accelerationPlayer ;

    public float MaxSpeedPlayer => maxSpeedPlayer;   // Assuming MaxSpeed is a property in ISpeedProvider
    public float AccelerationPlayer => accelerationPlayer;   // Assuming Acceleration is a property in ISpeedProvider
    public float CurrentSpeed => 0f;   // not used here, but present for the interface
}