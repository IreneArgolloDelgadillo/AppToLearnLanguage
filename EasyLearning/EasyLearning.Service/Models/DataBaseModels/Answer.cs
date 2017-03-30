using System.Collections.Generic;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// this represent the answer option that has some exercise like Simple selecion exercise
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Gets or sets the answer identifier.
        /// </summary>
        /// <value>
        /// The answer identifier.
        /// </value>
        public int AnswerId { get; set; }

        /// <summary>
        /// Gets or sets the sentence.
        /// </summary>
        /// <value>
        /// The sentence.
        /// </value>
        public virtual Sentence Sentence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Answer"/> is state.
        /// </summary>
        /// <value>
        ///   <c>true</c> if state; otherwise, <c>false</c>.
        /// </value>
        public bool State { get; set; }

        /// <summary>
        /// Gets or sets the s exercises.
        /// </summary>
        /// <value>
        /// The simple exercises.
        /// </value>
        public ICollection<S_Exercise> S_Exercises { get; set; }
    }
}