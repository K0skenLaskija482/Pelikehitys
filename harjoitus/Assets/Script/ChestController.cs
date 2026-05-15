using UnityEngine;

/// <summary>
/// Avaa arkun
/// </summary>
public class ChestController : MonoBehaviour
{
    [SerializeField] private Animator chestAnimator;

    // Julkinen metodi, jota painike voi kutsua
    public void OpenChest()
    {
        chestAnimator.SetTrigger("Open");
        
    }
}

