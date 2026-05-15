using UnityEngine;
/// <summary>
/// Sytytt‰‰ ja sammuttaa valon
/// </summary>
public class LightController : MonoBehaviour
{
    // Referenssi valokomponettiin
    private Light lampLight;
    private void Awake()
    {
        // Talletetaan komponentti muuttujaan
        lampLight = GetComponent<Light>();
    }
    private void Start()
    {
        // Tarkistetaan ett‰ valokomponentti lˆytyy
        if (lampLight == null)
        {
            Debug.LogError("Valokomponentti puuttuu");
        }
    }
    public void TurnOn()
    {
        lampLight.enabled = true;
        Debug.Log("Lamppu: P‰‰ll‰");
    }
    public void TurnOff()
    {
        lampLight.enabled = false;
        Debug.Log("Lamppu: Pois p‰‰lt‰");
    }
}