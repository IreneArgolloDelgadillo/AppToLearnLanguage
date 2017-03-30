using Newtonsoft.Json;

namespace EasyLearning.Service.Models.DataBaseModels
{
    /// <summary>
    /// This represent the entity that contains the languages native and to learn
    /// by user
    /// </summary>
    public class UserLanguages
    {
        /// <summary>
        /// Gets or sets the user languages identifier.
        /// </summary>
        /// <value>
        /// The user languages identifier.
        /// </value>
        public int UserLanguagesId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [JsonIgnore]
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets the native language.
        /// </summary>
        /// <value>
        /// The native language.
        /// </value>
        [JsonIgnore]
        public virtual Language NativeLanguage { get; set; }

        /// <summary>
        /// Gets or sets the language to learn.
        /// </summary>
        /// <value>
        /// The language to learn.
        /// </value>
        [JsonIgnore]
        public virtual Language LanguageToLearn { get; set; }
    }
}