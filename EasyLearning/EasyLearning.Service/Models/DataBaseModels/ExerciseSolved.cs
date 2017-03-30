using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// Represent the entity that contains the register of the all exercises responces
    /// </summary>
    public class ExerciseSolved
    {
        /// <summary>
        /// Gets or sets the exersice solved identifier.
        /// </summary>
        /// <value>
        /// The exersice solved identifier.
        /// </value>
        public int ExerciseSolvedId { get; set; }

        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        public int Score { get; set; }

        /// <summary>
        /// Gets or sets the last progress date.
        /// </summary>
        /// <value>
        /// The last progress date.
        /// </value>
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastProgressDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets the exercise.
        /// </summary>
        /// <value>
        /// The exercise.
        /// </value>
        public virtual LessonContent Exercise { get; set; }

    }
}