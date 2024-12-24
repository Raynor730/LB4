using System;
using System.Collections.Generic;

namespace LB4.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenderName { get; set; } = null!;

    //навигационное свойство 
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
