using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    [SerializeField] private float speed ; 
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private TargetProviderPlayer targetProvider;

    private void FixedUpdate()
    {
        if (!targetProvider) return; // Check if the TargetProviderPlayer is assigned

        Transform target = targetProvider.GetTarget(); // Get the target from the TargetProviderPlayer
        
        if (target)
        {
            enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, target.position, speed * Time.deltaTime); // Move towards the target
        }
    }
}