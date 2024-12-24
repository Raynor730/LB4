using System;
using System.Collections.Generic;

namespace LB4.Models;

// класс модели соответствует таблице в базе данных
// Экземпляр класса - это строка таблицы базы данных
public partial class AnimeType
{
    // свойста класса соответствуют полят таблицы в базе данных
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    // навигационное свойство
    // помогает связывать таблицы в коде
    // одному типу аниме соответствует многотайтлов аниме,
    // т.е. создается коллекция экземпляров AnimeTitle
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
