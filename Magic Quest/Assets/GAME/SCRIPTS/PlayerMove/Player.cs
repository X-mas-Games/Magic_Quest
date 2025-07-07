
using UnityEngine;

public class Player : MonoBehaviour
{
    private IMovable mover; // Interface for movement logic

    private void Awake()
    {
        mover = GetComponent<IMovable>();
    }

    private void FixedUpdate()
    {
        mover?.Move(); // Call the Move method from  IMovable interface
    }
}