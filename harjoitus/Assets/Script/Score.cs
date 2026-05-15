using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int scoreAmount = 10;
    [SerializeField] private TextMeshProUGUI pickupLabel;

    private int score;

    public int ScoreAmountSet
    {
        get => scoreAmount;
        set
        {
            scoreAmount = value;
            UpdateLabel();
        }
    }
    private void Awake()
    {
        UpdateLabel();
    }

    private void OnValidate()
    {
        UpdateLabel();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            player.AddScore(scoreAmount);

            Destroy(gameObject);
        }
    }

    private void UpdateLabel()
    {
        if (pickupLabel != null)
        {
            pickupLabel.text = "Score: " + scoreAmount;
        }
        else
        {
            Debug.LogWarning($"{name}: pickupLabel is not assigned (assign a TextMeshProUGUI component in the Inspector)", this);
        }
    }
}
