using System.Collections.Generic;

namespace EasyLearning.Models.ViewModel
{
    public class LessonModel
    {
        /// <summary>
        /// Gets or sets the lesson identifier.
        /// </summary>
        /// <value>
        /// The lesson identifier.
        /// </value>
        public int LessonId { get; set; }

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
        /// Gets or sets the order by level.
        /// </summary>
        /// <value>
        /// The order by level.
        /// </value>
        public int OrderByLevel { get; set; }
    }
}

