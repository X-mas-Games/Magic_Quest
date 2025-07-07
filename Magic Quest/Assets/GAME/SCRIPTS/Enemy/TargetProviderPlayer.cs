
using UnityEngine;

 public class TargetProviderPlayer : MonoBehaviour, ITargetProvider
{
    [SerializeField] private Transform target; // The target Transform to follow
    
    public Transform GetTarget() => target; // Returns the target Transform
}