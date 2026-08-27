class Unit
{
    private float health;
    public string Name { get; }
    public float Health
    {
        get { return health; }
    }

    public int Damage { get; }
    public float Armor { get; }
    public Unit(string name)
    {
        Name = name;
        health = 100f;
        Damage = 5;
        Armor = 0.6f;
    }

    public Unit() : this("Unknown Unit")
    public float GetRealHealth()
    {
        return Health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        health = Health - value * Armor;

        return Health <= 0f;
    }
}
