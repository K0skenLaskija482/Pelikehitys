using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        GetInteraction();
    }

    private void GetInteraction()
    {
        // Luetaan hiiren sijainti näytöllä
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        // Luodaan säde joka kulkee kamerasta hiiren sijaintiin
        Ray interactionRay = Camera.main.ScreenPointToRay(mousePosition);
        // Tutkitaan osuuko säde johonkin objektiin. Säteen pituus on 3.
        if (Physics.Raycast(interactionRay, out RaycastHit
        interactionInfo, 3f))
        {
            // Haetaan rajapinta jos löytyy (null = ei löydy)
            /*IInteractable interactable =
            interactionInfo.collider.GetComponent<IInteractable>();
            // Löytyikö rajapinta?
            if (interactable != null)
            {
                // Löytyi! Kutsutaan objektin Interact() -metodia
                interactable.Interact();
            }
            else
            {
                print("Objekti ei ole vuorovaikutteinen");
            }*/
        }
    }
}

