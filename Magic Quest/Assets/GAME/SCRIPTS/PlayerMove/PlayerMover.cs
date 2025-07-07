 
using UnityEngine;

 [RequireComponent(typeof(Transform))]
 public class PlayerMover : MonoBehaviour, IMovable
{ 
    
    [SerializeField] private SpeedConfig speedConfig;
    
    private float currentSpeedPlayer;

    public void Move()
    {
        currentSpeedPlayer = Mathf.MoveTowards(currentSpeedPlayer, speedConfig.MaxSpeedPlayer, speedConfig.AccelerationPlayer * Time.fixedDeltaTime); // Accelerate towards max speed
        transform.position += Vector3.forward * (currentSpeedPlayer * Time.fixedDeltaTime); // Move forward based on current speed
    }
}