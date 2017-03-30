namespace EasyLearning.Models.ViewModel
{
    public class UserLanguagesModel
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the native language.
        /// </summary>
        /// <value>
        /// The native language.
        /// </value>
        public string NativeLanguage { get; set; }

        /// <summary>
        /// Gets or sets the current language to learn.
        /// </summary>
        /// <value>
        /// The current language to learn.
        /// </value>
        public string LanguageTolearn { get; set; }

        /// <summary>
        /// Gets or sets the language tolearn identifier.
        /// </summary>
        /// <value>
        /// The language tolearn identifier.
        /// </value>
        public int LanguageTolearnId { get; set; }
    }

}