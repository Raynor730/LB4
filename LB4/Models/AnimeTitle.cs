using System;
using System.Collections.Generic;

namespace LB4.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public short IdTypeOfAnime { get; set; }

    public int IdModerator { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public int? YearOfRelease { get; set; }

    public string? Description { get; set; }

    public string? Poster { get; set; }

    public short? SountOfSeries { get; set; }

    public short? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string Studio { get; set; } = null!;


    // навигационные свойства
    // одному тайтлу соответствует только одинг тип аниме
    public virtual Genre Genre { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual AnimeType AnimeType { get; set; } = null!;
}
