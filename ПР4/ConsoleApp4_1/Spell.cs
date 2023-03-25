using System;
class Spell
{
    public string Name { get; set; }
    public int ManaCost { get; set; }
    public string Effect { get; set; }

    public Spell(string name, int manaCost, string effect)
    {
        Name = name;
        ManaCost = manaCost;
        Effect = effect;
    }

    public string ApplyEffect()
    {
        return Effect;
    }
}