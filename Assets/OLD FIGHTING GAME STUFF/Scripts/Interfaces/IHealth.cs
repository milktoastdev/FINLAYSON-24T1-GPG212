/*
public delegate void IHealthDelegateEvent();

public event IHealthDelegateEvent PlayerDefeated;

public void OnPlayerDefeated()
{
    PlayerDefeated?.Invoke();
}
*/
public interface IHealth
{
    public float Health { get; set; }

    // Calculate & apply damage
    public float Damaged(float amount);

    // Calculate & apply healing
    public float Healed(float amount);

    public void Defeated();
}