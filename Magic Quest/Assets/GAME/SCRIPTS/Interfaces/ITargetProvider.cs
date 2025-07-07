using UnityEngine;

public interface ITargetProvider // This interface defines a contract for providing a target transform in the game.
{
    Transform GetTarget();  // Method to retrieve the target transform.
}