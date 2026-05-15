using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Luokka on vuorovaikutuksessa painikkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            PressButton();
        }
    }
    public void PressButton()
    {
        if (chest != null)
        {
            print("testi");
            chest.OpenChest();
        }
    }
}
