
namespace EasyLearning.Service.Models.ServiceModels
{
    /// <summary>
    /// the class TrueFalse model 
    /// </summary>
    public class TrueFalseModel
    {
        /// <summary>
        /// Gets or sets the true false identifier.
        /// </summary>
        /// <value>
        /// The true false identifier.
        /// </value>
        public int TrueFalseId { get; set; }

        /// <summary>
        /// Gets or sets the enunciate.
        /// </summary>
        /// <value>
        /// The enunciate.
        /// </value>
        public string Enunciate { get; set; }

        /// <summary>
        /// Gets or sets the sentence.
        /// </summary>
        /// <value>
        /// The sentence.
        /// </value>
        public string Sentence { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public string PathImage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TrueFalseModel"/> is answer.
        /// </summary>
        /// <value>
        ///   <c>true</c> if answer; otherwise, <c>false</c>.
        /// </value>
        public bool Answer { get; set; }

        /// <summary>
        /// Gets or sets the puntuation.
        /// </summary>
        /// <value>
        /// The puntuation.
        /// </value>
        public int Puntuation { get; set; }
    }
}