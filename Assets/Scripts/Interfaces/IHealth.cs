public interface IHealth
{
    // Set starting health
    public void SetHealth(float health);
    
    // Get current health
    public void GetHealth(float health);
    
    // Calculate & apply damage
    public void Damaged(float amount);
    
    // Calculate & apply healing
    public void Healed(float amount);
    
    // Defeat player character or summoned creature
    public void Defeated();
}