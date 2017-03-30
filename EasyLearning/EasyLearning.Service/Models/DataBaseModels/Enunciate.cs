namespace EasyLearning.Service.Models.DataBaseModels
{
    public class Enunciate
    {
        public int EnunciateId { get; set; }

        /// <summary>
        /// Gets or sets the grammar of enunciate.
        /// </summary>
        /// <value>
        /// The grammar of enunciate.
        /// </value>
        public string GrammarOfEnunciate { get; set; }

        /// <summary>
        /// Gets or sets the belongs language.
        /// </summary>
        /// <value>
        /// The belongs language of the enunciate.
        /// </value>
        public virtual Language BelongsLanguage { get; set; }
    }
}