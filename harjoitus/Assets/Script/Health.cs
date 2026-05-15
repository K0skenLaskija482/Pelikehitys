using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    [SerializeField] private TextMeshProUGUI healthText;

    private int currentHealth;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }

    void Awake()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }
    public void Modify(int amount)
    {
        currentHealth += amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthText();
    }
    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;
        }
        else
        {
            Debug.LogWarning($"{name}: healthText is not assigned (assign a TextMeshProUGUI component in the Inspector)");
        }
    }
}
