namespace EasyLearning.Models.ViewModel
{
    /// <summary>
    /// this model represent a example in two laguages (native and user language to learn) of a grammar tip
    /// and the example traduction
    /// </summary>
    public class ExampleModel
    {
        /// <summary>
        /// Gets or sets the example in native language.
        /// </summary>
        /// <value>
        /// The example in native language.
        /// </value>
        public string ExampleOnNativeLanguage { get; set; }

        /// <summary>
        /// Gets or sets the example in language to learn.
        /// </summary>
        /// <value>
        /// The example in language to learn.
        /// </value>
        public string ExampleOnLanguageToLearn { get; set; }
    }
}