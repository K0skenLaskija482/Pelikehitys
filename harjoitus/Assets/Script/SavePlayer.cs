using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hakee pelaajan scriptin
            Player player = other.GetComponent<Player>();

            // Jos pelaaja löytyi, kutsutaan Save()
            if (player != null)
            {
                player.Save();
                Debug.Log("Peli tallennettu!");
            }
        }
    }
}
