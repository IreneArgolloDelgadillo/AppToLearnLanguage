using System;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent the bitacora for the language to learn that change the user
    /// </summary>
    public class LearningHistory
    {
        /// <summary>
        /// Gets or sets the learning history identifier.
        /// </summary>
        /// <value>
        /// The learning history identifier.
        /// </value>
        public int LearningHistoryId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets the language to learn.
        /// </summary>
        /// <value>
        /// The language to learn.
        /// </value>
        public virtual Language LanguageToLearn { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime dateTime { get; set; }
    }
}