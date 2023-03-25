using System;

class Program
{
    static void Main(string[] args)
    {
Wizard wizard = new Wizard("Беребашарах", 40);
Spell fireball = new Spell("ФОРМУРАФАШАРАЗАН", 20, "ФОООРМАННН!");
Spell lightning = new Spell("Бееерик", 10, "БЕРИГАН ЗЕР ВАН!");
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
        wizard.CastSpell(fireball);
        wizard.CastSpell(lightning);
    }
}

class Wizard
{
    public string Name { get; set; }
    public int Mana { get; set; }

    public Wizard(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }

    public void CastSpell(Spell spell)
    {
        if (spell.ManaCost > Mana)
        {
            int manaNeeded = spell.ManaCost - Mana;
            Console.WriteLine($"Для использования {spell.Name} не хватает {manaNeeded} единиц маны. Хлебните зелья!");
            return;
        }

        Console.WriteLine($"{Name} колдует! -{spell.ApplyEffect()}->>");
        Mana -= spell.ManaCost;
    }
}
