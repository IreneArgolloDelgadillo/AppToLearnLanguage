using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// represent the difficult to learn a language
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Gets or sets the level identifier.
        /// </summary>
        /// <value>
        /// The level identifier.
        /// </value>
        public int LevelId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the order by difficulty.
        /// </summary>
        /// <value>
        /// The order by difficulty.
        /// </value>
        public int OrderByDifficulty { get; set; }

        /// <summary>
        /// Gets or sets the lessons.
        /// </summary>
        /// <value>
        /// The lessons.
        /// </value>
        public ICollection<Lesson> Lessons { get; set; }

        /// <summary>
        /// Gets or sets the language to learn.
        /// </summary>
        /// <value>
        /// The language to learn.
        /// </value>
        public Language LanguageToLearn { get; set; }

        /// <summary>
        /// Gets or sets the native language.
        /// </summary>
        /// <value>
        /// The native language.
        /// </value>
        public Language BelongsLanguage { get; set; }
    }
}