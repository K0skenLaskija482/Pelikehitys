[System.Serializable]
public class PlayerData
{
    // Talletettavat tilatiedot
    public int health;
    public int score;

    // Konstruktori, joka alustaa muuttujat
    public PlayerData(Player player)
    {
        health = player.GetComponent<Health>().CurrentHealth;
        score = player.GetComponent<Player>().Score;
    }
}