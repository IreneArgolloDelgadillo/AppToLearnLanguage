namespace EasyLearning.Service.Models.ServiceModels
{
    public class UserLanguageModel
    {
        /// <value>
        /// The user language model identifier.
        /// </value>
        public int UserLanguageModelId{get;set;}

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the native language identifier.
        /// </summary>
        /// <value>
        /// The native language identifier.
        /// </value>
        public int NativeLanguageId { get; set; }

        /// <summary>
        /// Gets or sets the native language.
        /// </summary>
        /// <value>
        /// The native language.
        /// </value>
        public string NativeLanguage { get; set; }

        /// <summary>
        /// Gets or sets the language tolearn identifier.
        /// </summary>
        /// <value>
        /// The language tolearn identifier.
        /// </value>
        public int LanguageTolearnId { get; set; }

        /// <summary>
        /// Gets or sets the language tolearn.
        /// </summary>
        /// <value>
        /// The language tolearn.
        /// </value>
        public string LanguageTolearn { get; set; }
    }
}