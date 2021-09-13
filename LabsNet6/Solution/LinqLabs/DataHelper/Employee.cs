namespace DataHelper;

public class Employee {
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? Manager { get; set; }
    public DateTime BirthDate { get; set; }
    public char Gender { get; set; }
    public int SickLeaveHours { get; set; }
    public override string ToString() => $"{ID} - {Name} ({Gender}) - Born {BirthDate.ToShortDateString()} - Sick: {SickLeaveHours} - Mgr: {Manager}";
}
