using UnityEngine;
using UnityEngine.InputSystem;

public class Warrior : Character
{
    private void Update()
    {
        if (Keyboard.current.sKey.isPressed)
        {
            TakeDamage(10);
        }
    }

    public override void Attack()
    {
        Debug.Log($"{Name} hyökkää miekalla!");
    }
}
