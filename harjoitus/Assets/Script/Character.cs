using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [field: SerializeField] protected string Name { get; set; }
    [field: SerializeField] protected float Health { get; set; }

    public float HealthValue
    {
        get { return Health; }
    }
    public void TakeDamage(int damageAmmount)
    {
        Health -= damageAmmount;
        Debug.Log($"{Name} sai {damageAmmount} vahinkoa! HP: {Health}");

        if (Health <= 0)
        {
            Debug.Log($"{Name} hävisi taistelun!");
        }
    }

    public virtual void Attack()
    {
        Debug.Log($"{Name} hyökkää!");
    }
}
