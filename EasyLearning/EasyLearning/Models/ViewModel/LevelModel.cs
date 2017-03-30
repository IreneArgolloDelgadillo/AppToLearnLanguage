using System.Collections.Generic;

namespace EasyLearning.Models.ViewModel
{
    public class LevelModel
    {
        /// <summary>
        /// The id for a level.
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// A Integer to represent the difficulty of a level.
        /// </summary>
        public int OrderByDifficulty { get; set; }

        /// <summary>
        /// The languageId that it corresponds.
        /// </summary>
        public int BelongsLanguage { get; set; }

        /// <summary>
        /// The name for a level.
        /// Ex: A1, A2, B1, B2.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The lessons for a level.
        /// </summary>
        public ICollection<LessonModel> Lessons { get; set; } = new List<LessonModel>();
    }
}