using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent a topic to learn a language
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Gets or sets the lesson identifier.
        /// </summary>
        /// <value>
        /// The lesson identifier.
        /// </value>
        public int LessonId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        [Required]
        public virtual Level Level { get; set; }

        /// <summary>
        /// Gets or sets the order by level.
        /// </summary>
        /// <value>
        /// The order by level.
        /// </value>
        public int OrderByLevel { get; set; }

        /// <summary>
        /// Gets or sets the contents.
        /// </summary>
        /// <value>
        /// The contents.
        /// </value>
        public ICollection<LessonContent> Contents { get; set; }
    }
}