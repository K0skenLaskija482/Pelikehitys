using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{
    private Health health;

    [SerializeField] private TMP_Text hpText;
    [SerializeField] private TMP_Text scoreText;

    public int Score { get; private set; }

    void Awake()
    {
        health = GetComponent<Health>();
    }

    private void Start()
    {
        if (health == null)
        {
            Debug.LogError("Health-komponentti puuttuu");
        }

        Load();
        UpdateUI();
    }

    private void Update()
    {
        if (Keyboard.current.tKey.wasPressedThisFrame)
        {
            TakeDamage(1);
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            Heal(1);
        }

        // TESTI: lisää pisteitä
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            AddScore(10);
        }

        if (Keyboard.current.yKey.wasPressedThisFrame)
        {
            Save();
        }
    }

    public void TakeDamage(int amount)
    {
        health.Modify(-amount);
        UpdateUI();
    }

    public void Heal(int amount)
    {
        health.Modify(amount);
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        Score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (hpText != null)
        {
            hpText.text = "HP: " + health.CurrentHealth;
        }

        if (scoreText != null)
        {
            scoreText.text = "Score: " + Score;
        }
    }

    public void Save()
    {
        try
        {
            Debug.Log("Testi: JSON-tallennus käynnissä");

            PlayerData playerData = new PlayerData(this);

            string json = JsonUtility.ToJson(playerData, true);

            File.WriteAllText(Application.dataPath + "/playerdata.json", json);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Tallennus epäonnistui: " + e.Message);
        }
    }

    public void Load()
    {
        try
        {
            Debug.Log("Testi: JSON-lataus käynnissä");

            string path = Application.dataPath + "/playerdata.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);

                PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);

                health.CurrentHealth = playerData.health;
                Score = playerData.score;
            }
            else
            {
                Debug.LogWarning("Tallennustiedostoa ei löytynyt.");
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Lataus epäonnistui: " + e.Message);
        }
    }
}
