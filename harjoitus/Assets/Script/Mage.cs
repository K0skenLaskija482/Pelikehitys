using UnityEngine;
using UnityEngine.InputSystem;

public class Mage : Character
{
    private void Update()
    {
        if (Keyboard.current.fKey.isPressed)
        {
            TakeDamage(10);
        }
    }
    private void Start()
    {
        Attack();
    }

    public override void Attack()
    {
        Debug.Log($"{Name} hyökkää loitsulla!");
    }
}
