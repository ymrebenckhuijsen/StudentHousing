using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentHousing.Models;

namespace StudentHousing.Pages;

public class TakenModel : PageModel
{
    public List<SchoonmaakTaak> Taken { get; set; } = new();

    public void OnGet()
    {
        Taken = new List<SchoonmaakTaak>
        {
            new() { Id = 1, Omschrijving = "Keuken schoonmaken", Ruimte = "Keuken",
                Verantwoordelijke = "Student 1", Deadline = new DateOnly(2026, 11, 13) },
            new() { Id = 2, Omschrijving = "Badkamer poetsen", Ruimte = "Badkamer",
                Verantwoordelijke = "Student 2", Deadline = new DateOnly(2026, 11, 14),
                Status = TaakStatus.Bezig },
            new() { Id = 3, Omschrijving = "Vuilnis buiten zetten", Ruimte = "Gang",
                Verantwoordelijke = "Student 3", Deadline = new DateOnly(2026, 11, 10),
                Status = TaakStatus.Voltooid },
            new() { Id = 4, Omschrijving = "Woonkamer stofzuigen", Ruimte = "Woonkamer",
                Verantwoordelijke  = "Student 4", Deadline = new DateOnly(year:2026, month:11, day:13),
                Status = TaakStatus.Bezig}
        };
        Taken = Taken.OrderBy(t => t.Deadline).ToList();
    }
}