namespace DataHelper;

public class DicePlayer {
    public string Name { get; set; } = string.Empty;
    public List<(int FirstDice, int SecondDice)> DiceRolls { get; set; } = new();

    public override string ToString() => $"{Name} - {string.Concat(DiceRolls.Select(r => $"({r.FirstDice}, {r.SecondDice}) "))}";
}
