using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager_t11 : MonoBehaviour
{
    public Mage mage;
    public Warrior warrior;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.xKey.isPressed)
        {
            Debug.Log("mage hyökkääsi!");
            warrior.TakeDamage(15);
            return;
        }

        if (Mouse.current.leftButton.isPressed)
        {
            Debug.Log("warrior hyökkääsi!");
            mage.TakeDamage(20);
            return;
        }

        if (mage.HealthValue <= 0)
        {
            Debug.Log("Warrior voitti");
            return;
        }

        if (warrior.HealthValue <= 0)
        {
            Debug.Log("Mage voitti");
            return;
        }
    }
}

