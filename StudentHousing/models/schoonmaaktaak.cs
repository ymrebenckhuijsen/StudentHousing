namespace StudentHousing.Models;

public enum TaakStatus { Open, Bezig, Voltooid }

public class SchoonmaakTaak
{
    public int Id { get; set; }
    public string Omschrijving { get; set; } = "";
    public string Ruimte { get; set; } = "";
    public string Verantwoordelijke { get; set; } = "";
    public DateOnly Deadline { get; set; }
    public TaakStatus Status { get; set; } = TaakStatus.Open;
}